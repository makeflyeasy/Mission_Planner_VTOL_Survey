﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MissionPlanner.Utilities;

namespace MissionPlanner.Utilities
{
    public class Grid
    {
        const double rad2deg = (180 / Math.PI);
        const double deg2rad = (1.0 / rad2deg);

        public struct linelatlng
        {
            // start of line
            public utmpos p1;
            // end of line
            public utmpos p2;
            // used as a base for grid along line (initial setout)
            public utmpos basepnt;
        }

        public enum StartPosition
        {
            Home = 0,
            BottomLeft = 1,
            TopLeft = 2,
            BottomRight = 3,
            TopRight = 4,
            Point = 5
        }

        public static PointLatLngAlt StartPointLatLngAlt = PointLatLngAlt.Zero;

        static void addtomap(linelatlng pos)
        {

        }

        static void addtomap(utmpos pos, string tag)
        {

        }

        public static async Task<List<PointLatLngAlt>> CreateCorridorAsync(List<PointLatLngAlt> polygon, double altitude,
            double distance,
            double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter,
            float minLaneSeparation, double width, float leadin = 0)
        {
            return await Task.Run(() => CreateCorridor(polygon, altitude, distance, spacing, angle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, width, leadin));
        }

        public static List<PointLatLngAlt> CreateCorridor(List<PointLatLngAlt> polygon, double altitude, double distance,
            double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter,
            float minLaneSeparation, double width, float leadin = 0)
        {
            if (spacing < 4 && spacing != 0)
                spacing = 4;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            var lanes = (width / distance)+2;
            var start = (int) ((lanes / 2) * -1);
            var end = start * -1;
            int contrary = -1;
            if (startpos == StartPosition.BottomLeft)
            {

            }
            else if (startpos == StartPosition.TopLeft)
            {
                distance = -distance;
            }
            else if (startpos == StartPosition.BottomRight)
            {
                utmpositions.Reverse();
                distance = -distance;
            }
            else if (startpos == StartPosition.TopRight)
            {
                utmpositions.Reverse();
                
            }
            for (int lane = start; lane <= end; lane++)
            {
                // correct side of the line we are on because of list reversal
                int multi = 1;
                
                if ((lane - start) % 2 == 1)
                    multi = -1;
                contrary = contrary * -1;

                if (lane < 0)
                {
                    var a = -(distance * multi * (lane + 1) - distance* multi / 2);
                    GenerateOffsetPath(utmpositions, a , spacing, utmzone)
                             .ForEach(pnt => { ans.Add(pnt); });
                }
                else if (lane > 0)

                {
                    var a = distance * multi * (lane - 1) + distance / 2 * (contrary);
                    GenerateOffsetPath(utmpositions, a , spacing, utmzone)
                             .ForEach(pnt => { ans.Add(pnt); });
                }
                if(lane!=0 )
                utmpositions.Reverse();

                
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }
        public static List<PointLatLngAlt> CreateCorridor1(List<PointLatLngAlt> polygon, double altitude, double distance,
            double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter,
            float minLaneSeparation, double width, float leadin = 0)
        {
            if (spacing < 4 && spacing != 0)
                spacing = 4;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            var lanes = (width / distance);
            var start = (int)((lanes / 2) * -1);
            var end = start * -1;
            // int contrary = -1;
            if (startpos == StartPosition.BottomLeft)
            { 
               
                distance = -distance; 
            }
            else if (startpos == StartPosition.TopLeft)
            { 
                   
            }
            else if(startpos == StartPosition.BottomRight)
            {
                utmpositions.Reverse();
                
            }
            else if(startpos == StartPosition.TopRight)
            {
                utmpositions.Reverse();
                distance = -distance;
            }
            for (int lane = start; lane <= end; lane++)
            {
                // correct side of the line we are on because of list reversal
                int multi = 1;

                if ((lane - start) % 2 == 1)
                    multi = -1;
          
                    
                    GenerateOffsetPath(utmpositions, distance * multi *lane , spacing, utmzone)
                             .ForEach(pnt => { ans.Add(pnt); });
          
                    utmpositions.Reverse();


            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        private static List<utmpos> GenerateOffsetPath(List<utmpos> utmpositions, double distance, double spacing, int utmzone)
        {
            List<utmpos> ans = new List<utmpos>();

            utmpos oldpos = utmpos.Zero;

            for (int a=0;a<utmpositions.Count-2;a++)
            {
                var prevCenter = utmpositions[a];
                var currCenter = utmpositions[a+1];
                var nextCenter = utmpositions[a+2];

                var l1bearing = prevCenter.GetBearing(currCenter);
                var l2bearing = currCenter.GetBearing(nextCenter);

                var l1prev = newpos(prevCenter, l1bearing + 90, distance);
                var l1curr = newpos(currCenter, l1bearing + 90, distance);

                var l2curr = newpos(currCenter, l2bearing + 90, distance);
                var l2next = newpos(nextCenter, l2bearing + 90, distance);

                var l1l2center = FindLineIntersectionExtension(l1prev, l1curr, l2curr, l2next);

                //start
                if (a == 0)
                {
                    // add start
                    l1prev.Tag = "S";
                    ans.Add(l1prev);

                    // add start/trigger
                    l1prev.Tag = "SM";
                    ans.Add(l1prev);

                    oldpos = l1prev;
                }

                //spacing
                if (spacing > 0)
                {
                    for (int d = (int)((oldpos.GetDistance(l1l2center)) % spacing);
                        d < (oldpos.GetDistance(l1l2center));
                        d += (int)spacing)
                    {
                        double ax = oldpos.x;
                        double ay = oldpos.y;

                        newpos(ref ax, ref ay, l1bearing, d);
                        var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                        ans.Add(utmpos2);
                    }
                }

                //end of leg
                l1l2center.Tag = "S";
                ans.Add(l1l2center);
                
                oldpos = l1l2center;

                // last leg
                if ((a + 3) == utmpositions.Count)
                {
                    if (spacing > 0)
                    {
                        for (int d = (int)((l1l2center.GetDistance(l2next)) % spacing);
                            d < (l1l2center.GetDistance(l2next));
                            d += (int)spacing)
                        {
                            double ax = l1l2center.x;
                            double ay = l1l2center.y;

                            newpos(ref ax, ref ay, l2bearing, d);
                            var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            ans.Add(utmpos2);
                        }
                    }

                    l2next.Tag = "ME";
                    ans.Add(l2next);

                    l2next.Tag = "E";
                    ans.Add(l2next);
                }
            }

            return ans;
        }
        public static async Task<List<PointLatLngAlt>> CreateGridAsync1(List<PointLatLngAlt> polygon, double altitude,
           double distance, double spacing, double angle, double TurnAngle, double overshoot1, double overshoot2, StartPosition startpos,
           bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {
            return await Task.Run((() => CreateGrid1(polygon, altitude, distance, spacing, angle, TurnAngle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, leadin, HomeLocation)));
            
        }
        public static List<PointLatLngAlt> CreateGrid1(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, double angle,double TurnAngle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {

            //DoDebug();

            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();


            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;

            addtomap(new utmpos(x, y, utmzone), "Base");

            // get left extent
            double xb1 = x;
            double yb1 = y;
            // to the left
            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2 + distance);
            // backwards
            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2 + distance);

            utmpos left = new utmpos(xb1, yb1, utmzone);

            addtomap(left, "left");

            // get right extent
            double xb2 = x;
            double yb2 = y;
            // to the right
            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2 + distance);
            // backwards
            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2 + distance);

            utmpos right = new utmpos(xb2, yb2, utmzone);

            addtomap(right, "right");

            // set start point to left hand side
            x = xb1;
            y = yb1;

            // draw the outergrid, this is a grid that cover the entire area of the rectangle plus more.
            while (lines < ((diagdist + distance * 2) / distance))
            {
                // copy the start point to generate the end point
                double nx = x;
                double ny = y;
                newpos(ref nx, ref ny, angle, diagdist + distance * 2);

                linelatlng line = new linelatlng();
                line.p1 = new utmpos(x, y, utmzone);
                line.p2 = new utmpos(nx, ny, utmzone);
                line.basepnt = new utmpos(x, y, utmzone);
                grid.Add(line);

                // addtomap(line);

                newpos(ref x, ref y, angle + 90, distance);
                lines++;
            }

            // find intersections with our polygon

            // store lines that dont have any intersections
            List<linelatlng> remove = new List<linelatlng>();

            int gridno = grid.Count;

            // cycle through our grid
            for (int a = 0; a < gridno; a++)
            {
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], grid[a].p1, grid[a].p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > grid[a].p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < grid[a].p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 0) // outside our polygon
                {
                    if (!PointInPolygon(grid[a].p1, utmpositions) && !PointInPolygon(grid[a].p2, utmpositions))
                        remove.Add(grid[a]);
                }
                else if (crosses == 1) // bad - shouldnt happen
                {

                }
                else if (crosses == 2) // simple start and finish
                {
                    linelatlng line = grid[a];
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                    grid[a] = line;
                }
                else // multiple intersections
                {
                    linelatlng line = grid[a];
                    remove.Add(line);

                    while (matchs.Count > 1)
                    {
                        linelatlng newline = new linelatlng();

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p1 = closestpoint;
                        matchs.Remove(closestpoint);

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p2 = closestpoint;
                        matchs.Remove(closestpoint);

                        newline.basepnt = line.basepnt;

                        grid.Add(newline);
                    }
                }
            }

            // cleanup and keep only lines that pass though our polygon
            foreach (linelatlng line in remove)
            {
                grid.Remove(line);
            }

            // debug
            foreach (linelatlng line in grid)
            {
                addtomap(line);
            }

            if (grid.Count == 0)
                return ans;

            // pick start positon based on initial point rectangle
            utmpos startposutm;
            utmpos startposutmright;
            startposutmright = utmpositions[0];

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].x > startposutmright.x)
                {
                    startposutmright = utmpositions[i];
                  
                }
            }
            utmpos startposutmtop;
            startposutmtop = utmpositions[0];
         

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].y > startposutmtop.y)
                {
                    startposutmtop = utmpositions[i];
                    
                }
            }
            utmpos startposutmleft;
            startposutmleft= utmpositions[0];
         

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].x < startposutmleft.x)
                {
                    startposutmleft = utmpositions[i];
                    
                }
            }
            utmpos startposutmbottom;
            startposutmbottom = utmpositions[0];
          

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].y < startposutmbottom.y)
                {
                    startposutmbottom = utmpositions[i];
                    
                }
            }

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = startposutmbottom/*new utmpos(area.Left, area.Bottom, utmzone)*/;
                    break;
                case StartPosition.BottomRight:
                    startposutm = startposutmbottom/*new utmpos(area.Right, area.Bottom, utmzone)*/;
                    break;
                case StartPosition.TopLeft:
                    startposutm = startposutmtop /*new utmpos(area.Left, area.Top, utmzone)*/;
                    break;
                case StartPosition.TopRight:
                    startposutm = startposutmtop/*new utmpos(area.Right, area.Top, utmzone)*/;
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);

            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);
            linelatlng last;
            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }
            int amount = grid.Count;
            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle

            utmpos newstart;
            utmpos newend;

            int am = 0;
            while (amount > 0)
            {
                if (angle == 90) 
                {
                    if (amount > 0)
                    {
                        am++;
                        newstart = newpos(closest.p2, angle, leadin);

                        newstart.Tag = "S";
                        addtomap(newstart, "S");
                        ans.Add(newstart);

                        if (leadin < 0)
                        {
                            var p2 = new utmpos(newstart) { Tag = "SM" };
                            addtomap(p2, "SM");
                            ans.Add(p2);
                        }
                        else
                        {
                            closest.p2.Tag = "SM";
                            addtomap(closest.p2, "SM");
                            ans.Add(closest.p2);
                        }

                        if (spacing > 0)
                        {
                            for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                                d < (closest.p1.GetDistance(closest.p2));
                                d += spacing)
                            {
                                double ax = closest.p2.x;
                                double ay = closest.p2.y;

                                newpos(ref ax, ref ay, angle, -d);
                                var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                                addtomap(utmpos2, "M");
                                ans.Add(utmpos2);
                            }
                        }
                        newend = newpos(closest.p1, angle - TurnAngle, -overshoot1);
                        if (overshoot2 < 0)
                        {
                            var p2 = new utmpos(newend) { Tag = "ME" };
                            addtomap(p2, "ME");
                            ans.Add(p2);
                        }
                        else
                        {
                            closest.p1.Tag = "ME";
                            addtomap(closest.p1, "ME");
                            ans.Add(closest.p1);
                        }

                        newend.Tag = "E";
                        addtomap(newend, "E");
                        ans.Add(newend);

                        lastpnt = closest.p2;
                        amount--;
                        grid.Remove(closest);
                        if (amount == 0)
                            break;
                        last = closest;
                        closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                        var closest0 = closest;
                        var last0 = last;

                        {
                            if (closest.p1.x < last.p1.x)
                            {

                                last0.p1.x = closest.p1.x;
                                newend = newpos(last0.p1, angle - TurnAngle, -overshoot1);
                                newend.Tag = "E";
                                addtomap(newend, "E");
                                ans.Add(newend);

                            }
                            else
                            {

                                if (grid.Count != 1)
                                    grid.Remove(closest);


                                closest0.p2.x = last.p2.x;
                                newstart = newpos(closest0.p2, angle, leadin);

                                newstart.Tag = "E";
                                addtomap(newstart, "E");
                                ans.Add(newstart);
                            }

                            /*{
                                double c = 0;
                                double n, m = 0;
                                double dangle = 0;
                                double mangle = 0;
                                double x1, y1 = 0;
                                if (grid.Count != 1)
                                    grid.Remove(closest);

                                x1 = Math.Abs(closest.p1.x - last0.p1.x);
                                y1 = Math.Abs(closest.p1.y - last0.p1.y);
                                c = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

                                dangle = Math.Acos(distance / c);
                                mangle = Math.Acos(y1 / c);
                                m = Math.Sin(mangle - dangle) * distance;
                                n = Math.Cos(mangle - dangle) * distance;
                                if (closest.p1.y > last.p1.y&& closest.p1.x > last.p1.x) 
                                { 
                                    closest0.p1.y = n + last.p1.y;
                                    closest0.p1.x = m + last.p1.x;
                                    newstart = newpos(closest0.p1, angle, -leadin);
                                }
                                else if(closest.p1.y < last.p1.y && closest.p1.x < last.p1.x)
                                {
                                    last0.p1.y = n + closest0.p1.y;
                                    last0.p1.x = m + closest0.p1.x;
                                    newstart = newpos(last0.p1, angle, -leadin);
                                }
                                else if (closest.p1.y > last.p1.y && closest.p1.x < last.p1.x)
                                {
                                    last0.p1.y = -n + closest0.p1.y;
                                    last0.p1.x = m + closest0.p1.x;
                                    newstart = newpos(last0.p1, angle, -leadin);
                                }
                                else if (closest.p1.y < last.p1.y && closest.p1.x > last.p1.x)
                                {
                                    last0.p1.y = -n + closest0.p1.y;
                                    last0.p1.x = m + closest0.p1.x;
                                    newstart = newpos(last0.p1, angle, -leadin);
                                }



                                newstart.Tag = "S";


                                addtomap(newstart, "S");
                                ans.Add(newstart);
                            }*/
                        }
                    }
                    if (amount > 0)
                    {
                        am++;

                        newstart = newpos(closest.p1, angle, -leadin);

                        newstart.Tag = "SM";
                        addtomap(newstart, "SM");
                        ans.Add(newstart);

                        if (leadin < 0)
                        {
                            var p2 = new utmpos(newstart) { Tag = "SM" };
                            addtomap(p2, "SM");
                            ans.Add(p2);
                        }
                        else
                        {
                            closest.p1.Tag = "SM";
                            addtomap(closest.p1, "SM");
                            ans.Add(closest.p1);
                        }

                        if (spacing > 0)
                        {
                            for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                                d < (closest.p1.GetDistance(closest.p2));
                                d += spacing)
                            {
                                double ax = closest.p2.x;
                                double ay = closest.p2.y;

                                newpos(ref ax, ref ay, angle, -d);
                                var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                                addtomap(utmpos2, "M");
                                ans.Add(utmpos2);
                            }
                        }
                        newend = newpos(closest.p2, angle - TurnAngle, overshoot2);

                        if (overshoot2 < 0)
                        {
                            var p2 = new utmpos(newend) { Tag = "ME" };
                            addtomap(p2, "ME");
                            ans.Add(p2);
                        }
                        else
                        {
                            closest.p2.Tag = "ME";
                            addtomap(closest.p2, "ME");
                            ans.Add(closest.p2);
                        }

                        newend.Tag = "E";
                        addtomap(newend, "E");
                        ans.Add(newend);

                        lastpnt = closest.p2;
                        amount--;
                        grid.Remove(closest);
                        if (amount == 0)
                            break;
                        last = closest;
                        closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                        var closest0 = closest;
                        var last0 = last;
                        if (closest.p2.x > last.p2.x)
                        {

                            last0.p2.x = closest.p2.x;
                            newend = newpos(last0.p2, angle - TurnAngle, overshoot1);
                            newend.Tag = "S";
                            addtomap(newend, "S");
                            ans.Add(newend);
                        }
                        else
                        {

                            if (grid.Count != 1)
                                grid.Remove(closest);


                            closest0.p2.x = last.p2.x;
                            newstart = newpos(closest0.p2, angle, leadin);

                            newstart.Tag = "E";
                            addtomap(newstart, "E");
                            ans.Add(newstart);
                        }
                        /*{
                            double c = 0;
                            double n, m = 0;
                            double dangle = 0;
                            double mangle = 0;
                            double x1, y1 = 0;
                            if (grid.Count != 1)
                                grid.Remove(closest);

                            x1 = Math.Abs(closest.p2.x - last0.p2.x);
                            y1 = Math.Abs(closest.p2.y - last0.p2.y);
                            c = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

                            dangle = Math.Acos(distance / c);
                            mangle = Math.Acos(y1 / c);
                            m = Math.Sin(mangle - dangle) * distance;
                            n = Math.Cos(mangle - dangle) * distance;
                            if (closest.p2.y > last.p2.y && closest.p2.x > last.p2.x)
                            {
                                closest0.p2.y = n + last.p2.y;
                                closest0.p2.x = m + last.p2.x;
                                newstart = newpos(closest0.p2, angle, -leadin);
                            }
                            else if (closest.p2.y < last.p2.y && closest.p2.x < last.p2.x)

                            {
                                last0.p2.y = n + closest0.p2.y;
                                last0.p2.x = m + closest0.p2.x;
                                newstart = newpos(last0.p2, angle, -leadin);
                            }
                            else if (closest.p2.y > last.p2.y && closest.p2.x < last.p2.x)
                            {
                                last0.p2.y = -n + closest0.p2.y;
                                last0.p2.x = m + closest0.p2.x;
                                newstart = newpos(last0.p2, angle, -leadin);
                            }
                            else if (closest.p2.y < last.p2.y && closest.p2.x > last.p2.x)
                            {
                                last0.p2.y = -n + closest0.p2.y;
                                last0.p2.x = m + closest0.p2.x;
                                newstart = newpos(last0.p2, angle, -leadin);

                            }



                            newstart.Tag = "S";


                            addtomap(newstart, "S");
                            ans.Add(newstart);
                        }*/
                    }
                }
            
               else
                {
                    
                    {
                        if (amount > 0)
                        {


                            newstart = newpos(closest.p2, angle, leadin);

                            newstart.Tag = "S";
                            addtomap(newstart, "S");
                            ans.Add(newstart);

                             if (leadin < 0)
                             {
                                 var p2 = new utmpos(newstart) { Tag = "SM" };
                                 addtomap(p2, "SM");
                                 ans.Add(p2);
                             }
                             else
                             {
                                 closest.p2.Tag = "SM";
                                 addtomap(closest.p2, "SM");
                                 ans.Add(closest.p2);
                             }

                            if (spacing > 0)
                            {
                                for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                                    d < (closest.p1.GetDistance(closest.p2));
                                    d += spacing)
                                {
                                    double ax = closest.p2.x;
                                    double ay = closest.p2.y;

                                    newpos(ref ax, ref ay, angle, -d);
                                    var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                                    addtomap(utmpos2, "M");
                                    ans.Add(utmpos2);
                                }
                            }
                            newend = newpos(closest.p1, angle - TurnAngle, -overshoot1);
                            if (overshoot2 < 0)
                            {
                                var p2 = new utmpos(newend) { Tag = "ME" };
                                addtomap(p2, "ME");
                                ans.Add(p2);
                            }
                            else
                            {
                                closest.p1.Tag = "ME";
                                addtomap(closest.p1, "ME");
                                ans.Add(closest.p1);
                            }

                            newend.Tag = "E";
                            addtomap(newend, "E");
                            ans.Add(newend);

                            lastpnt = closest.p2;
                            amount--;
                            grid.Remove(closest);
                            if (amount == 0)
                                break;
                            last = closest;
                            closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                            var closest0 = closest;
                            var last0 = last;
                            if (closest.p1.x > last.p1.x)
                            {


                                last0.p1.x = closest.p1.x;
                                newend = newpos(last0.p1, angle - TurnAngle, -overshoot1);
                                newend.Tag = "E";
                                addtomap(newend, "E");
                                ans.Add(newend);

                            }
                            else
                            {
                                

                                closest0.p1.x = last.p1.x;
                                newstart = newpos(closest0.p1, angle, -leadin);

                                newstart.Tag = "E";
                                addtomap(newstart, "E");
                                ans.Add(newstart);

                            }
                            am++;
                        }
                        if (amount > 0)
                        {


                            newstart = newpos(closest.p1, angle, -leadin);

                            newstart.Tag = "S";
                            addtomap(newstart, "S");
                            ans.Add(newstart);

                            if (leadin < 0)
                             {
                                 var p2 = new utmpos(newstart) { Tag = "SM" };
                                 addtomap(p2, "SM");
                                 ans.Add(p2);
                             }
                             else
                             {
                                 closest.p1.Tag = "SM";
                                 addtomap(closest.p1, "SM");
                                 ans.Add(closest.p1);
                             }

                            if (spacing > 0)
                            {
                                for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                                    d < (closest.p1.GetDistance(closest.p2));
                                    d += spacing)
                                {
                                    double ax = closest.p2.x;
                                    double ay = closest.p2.y;

                                    newpos(ref ax, ref ay, angle, -d);
                                    var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                                    addtomap(utmpos2, "M");
                                    ans.Add(utmpos2);
                                }
                            }
                            newend = newpos(closest.p2, angle - TurnAngle, overshoot2);
                            if (overshoot2 < 0)
                            {
                                var p2 = new utmpos(newend) { Tag = "ME" };
                                addtomap(p2, "ME");
                                ans.Add(p2);
                            }
                            else
                            {
                                closest.p2.Tag = "ME";
                                addtomap(closest.p2, "ME");
                                ans.Add(closest.p2);
                            }

                            newend.Tag = "E";
                            addtomap(newend, "E");
                            ans.Add(newend);

                            lastpnt = closest.p2;
                            amount--;
                            grid.Remove(closest);
                            if (amount == 0)
                                break;
                            last = closest;
                            closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                            var closest0 = closest;
                            var last0 = last;
                            if (closest.p2.x < last.p2.x)
                            {

                                last0.p2.x = closest.p2.x;
                                newend = newpos(last0.p2, angle - TurnAngle, overshoot1);
                                newend.Tag = "S";
                                addtomap(newend, "S");
                                ans.Add(newend);
                            }
                            else
                            {
                                if (grid.Count != 1)
                                    grid.Remove(closest);
                                closest0.p2.x = last.p2.x;
                                newstart = newpos(closest0.p2, angle, leadin);

                                newstart.Tag = "E";
                                addtomap(newstart, "E");
                                ans.Add(newstart);

                            }
                            am++;

                        }
                        
                    }

                }



            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }



        public static async Task<List<PointLatLngAlt>> CreateGridAsync(List<PointLatLngAlt> polygon, double altitude,
            double distance, double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos,
            bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {
            return await Task.Run((() => CreateGrid(polygon, altitude, distance, spacing, angle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, leadin, HomeLocation)));
        }

        public static List<PointLatLngAlt> CreateGrid(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {
            //DoDebug();
         
            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();


            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;

            addtomap(new utmpos(x, y, utmzone), "Base");

            // get left extent
            double xb1 = x;
            double yb1 = y;
            // to the left
            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2 + distance);
            // backwards
            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2 + distance);

            utmpos left = new utmpos(xb1, yb1, utmzone);

            addtomap(left, "left");

            // get right extent
            double xb2 = x;
            double yb2 = y;
            // to the right
            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2 + distance);
            // backwards
            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2 + distance);

            utmpos right = new utmpos(xb2, yb2, utmzone);

            addtomap(right, "right");

            // set start point to left hand side
            x = xb1;
            y = yb1;

            // draw the outergrid, this is a grid that cover the entire area of the rectangle plus more.
            while (lines < ((diagdist + distance * 2) / distance))
            {
                // copy the start point to generate the end point
                double nx = x;
                double ny = y;
                newpos(ref nx, ref ny, angle, diagdist + distance * 2);

                linelatlng line = new linelatlng();
                line.p1 = new utmpos(x, y, utmzone);
                line.p2 = new utmpos(nx, ny, utmzone);
                line.basepnt = new utmpos(x, y, utmzone);
                grid.Add(line);

                // addtomap(line);

                newpos(ref x, ref y, angle + 90, distance);
                lines++;
            }

            // find intersections with our polygon

            // store lines that dont have any intersections
            List<linelatlng> remove = new List<linelatlng>();

            int gridno = grid.Count;

            // cycle through our grid
           for (int a = 0; a < gridno; a++)
            {
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], grid[a].p1, grid[a].p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > grid[a].p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < grid[a].p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 0) // outside our polygon
                {
                    if (!PointInPolygon(grid[a].p1, utmpositions) && !PointInPolygon(grid[a].p2, utmpositions)) ;
                        remove.Add(grid[a]);
                }
                else if (crosses == 1) // bad - shouldnt happen
                {

                }
                else if (crosses == 2) // simple start and finish
                {
                    linelatlng line = grid[a];
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                    grid[a] = line;
                }
                else // multiple intersections
                {
                    linelatlng line = grid[a];
                    remove.Add(line);

                    while (matchs.Count > 1)
                    {
                        linelatlng newline = new linelatlng();

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p1 = closestpoint;
                        matchs.Remove(closestpoint);

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p2 = closestpoint;
                        matchs.Remove(closestpoint);

                        newline.basepnt = line.basepnt;

                        grid.Add(newline);
                    }
                }

            }

            // cleanup and keep only lines that pass though our polygon
            foreach (linelatlng line in remove)
            {
                grid.Remove(line);
            }

            // debug
            foreach (linelatlng line in grid)
            {
                addtomap(line);
            }

            if (grid.Count == 0)
                return ans;

            // pick start positon based on initial point rectangle
            utmpos startposutm;
            utmpos startposutmright;
            startposutmright = utmpositions[0];

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].x > startposutmright.x)
                {
                    startposutmright = utmpositions[i];

                }
            }
            utmpos startposutmtop;
            startposutmtop = utmpositions[0];
         

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].y > startposutmtop.y)
                {
                    startposutmtop = utmpositions[i];
                    
                }
            }
            utmpos startposutmleft;
            startposutmleft= utmpositions[0];
         

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].x < startposutmleft.x)
                {
                    startposutmleft = utmpositions[i];
                    
                }
            }
            utmpos startposutmbottom;
            startposutmbottom = utmpositions[0];
          

            for (int i = 0; i < utmpositions.Count; i++)
            {
                if (utmpositions[i].y < startposutmbottom.y)
                {
                    startposutmbottom = utmpositions[i];
                    
                }
            }

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = /*startposutmbottom*/new utmpos(area.Left, area.Bottom, utmzone); 
                        break;
                case StartPosition.BottomRight:
                    startposutm = /*startposutmright*/new utmpos(area.Right, area.Bottom, utmzone); 
                    break;
                case StartPosition.TopLeft:
                    startposutm =/*startposutmleft */new utmpos(area.Left, area.Top, utmzone); 
                    break;
                case StartPosition.TopRight:
                    startposutm = /*startposutmtop*/new utmpos(area.Right, area.Top, utmzone); 
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);
            
            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);

            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle
 
            utmpos newstart;
            utmpos newend;
            newend.x = 0;
            newstart.x = 0;
            newend.y = 0;
            newstart.y = 0;
            while (grid.Count > 0)
            {
                // for each line, check which end of the line is the next closest
                if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                {
                    newstart = newpos(closest.p1, angle, -leadin);


                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin < 0)
                    {
                        var p2 = new utmpos(newstart) { Tag = "SM" };
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "SM";
                        addtomap(closest.p1, "SM");
                        ans.Add(closest.p1);
                    }

                    if (spacing > 0)
                    {
                        for (double d = (spacing - ((closest.basepnt.GetDistance(closest.p1)) % spacing));
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p1.x;
                            double ay = closest.p1.y;

                            newpos(ref ax, ref ay, angle, d);
                            var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos1, "M");
                            ans.Add(utmpos1);
                        }
                    }

                    newend = newpos(closest.p2, angle, overshoot1);


                    if (overshoot1 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "ME";
                        addtomap(closest.p2, "ME");
                        ans.Add(closest.p2);
                    }

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p2;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
                else
                {
                    newstart = newpos(closest.p2, angle, leadin);

                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin < 0)
                    {
                        var p2 = new utmpos(newstart) {Tag = "SM"};
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "SM";
                        addtomap(closest.p2, "SM");
                        ans.Add(closest.p2);
                    }

                    if (spacing > 0)
                    {
                        for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p2.x;
                            double ay = closest.p2.y;

                            newpos(ref ax, ref ay, angle, -d);
                            var utmpos2 = new utmpos(ax, ay, utmzone) {Tag = "M"};
                            addtomap(utmpos2, "M");
                            ans.Add(utmpos2);
                        }
                    }

                     newend = newpos(closest.p1, angle, -overshoot2);

                    if (overshoot2 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "ME";
                        addtomap(closest.p1, "ME");
                        ans.Add(closest.p1);
                    }
            
                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p1;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }


            }





            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        static Rect getPolyMinMax(List<utmpos> utmpos)
        {
            if (utmpos.Count == 0)
                return new Rect();

            double minx, miny, maxx, maxy;

            minx = maxx = utmpos[0].x;
            miny = maxy = utmpos[0].y;

            foreach (utmpos pnt in utmpos)
            {
                minx = Math.Min(minx, pnt.x);
                maxx = Math.Max(maxx, pnt.x);

                miny = Math.Min(miny, pnt.y);
                maxy = Math.Max(maxy, pnt.y);
            }

            return new Rect(minx, maxy, maxx - minx,miny - maxy);
        }

        // polar to rectangular
        static void newpos(ref double x, ref double y, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            x = x + distance * Math.Cos(degN * deg2rad);
            y = y + distance * Math.Sin(degN * deg2rad);
        }

        // polar to rectangular
        static utmpos newpos(utmpos input, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            double x = input.x + distance * Math.Cos(degN * deg2rad);
            double y = input.y + distance * Math.Sin(degN * deg2rad);

            return new utmpos(x, y, input.zone);
        }

        /// <summary>
        /// from http://stackoverflow.com/questions/1119451/how-to-tell-if-a-line-intersects-a-polygon-in-c
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2"></param>
        /// <param name="end2"></param>
        /// <returns></returns>
        public static utmpos FindLineIntersection(utmpos start1, utmpos end1, utmpos start2, utmpos end2)
        {
            double denom = ((end1.x - start1.x) * (end2.y - start2.y)) - ((end1.y - start1.y) * (end2.x - start2.x));
            //  AB & CD are parallel         
            if (denom == 0)
                return utmpos.Zero;
            double numer = ((start1.y - start2.y) * (end2.x - start2.x)) - ((start1.x - start2.x) * (end2.y - start2.y));
            double r = numer / denom;
            double numer2 = ((start1.y - start2.y) * (end1.x - start1.x)) - ((start1.x - start2.x) * (end1.y - start1.y));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
                return utmpos.Zero;
            // Find intersection point      
            utmpos result = new utmpos();
            result.x = start1.x + (r * (end1.x - start1.x));
            result.y = start1.y + (r * (end1.y - start1.y));
            result.zone = start1.zone;
            return result;
        }

        /// <summary>
        /// from http://stackoverflow.com/questions/1119451/how-to-tell-if-a-line-intersects-a-polygon-in-c
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2"></param>
        /// <param name="end2"></param>
        /// <returns></returns>
        public static utmpos FindLineIntersectionExtension(utmpos start1, utmpos end1, utmpos start2, utmpos end2)
        {
            double denom = ((end1.x - start1.x) * (end2.y - start2.y)) - ((end1.y - start1.y) * (end2.x - start2.x));
            //  AB & CD are parallel         
            if (denom == 0)
                return utmpos.Zero;
            double numer = ((start1.y - start2.y) * (end2.x - start2.x)) -
                           ((start1.x - start2.x) * (end2.y - start2.y));
            double r = numer / denom;
            double numer2 = ((start1.y - start2.y) * (end1.x - start1.x)) -
                            ((start1.x - start2.x) * (end1.y - start1.y));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
            {
                // line intersection is outside our lines.
            }
            // Find intersection point      
            utmpos result = new utmpos();
            result.x = start1.x + (r * (end1.x - start1.x));
            result.y = start1.y + (r * (end1.y - start1.y));
            result.zone = start1.zone;
            return result;
        }

        static utmpos findClosestPoint(utmpos start, List<utmpos> list)
        {
            utmpos answer = utmpos.Zero;
            double currentbest = double.MaxValue;

            foreach (utmpos pnt in list)
            {
                double dist1 = start.GetDistance(pnt);

                if (dist1 < currentbest)
                {
                    answer = pnt;
                    currentbest = dist1;
                }
            }

            return answer;
        }

        // Add an angle while normalizing output in the range 0...360
        static double AddAngle(double angle, double degrees)
        {
            angle += degrees;

            angle = angle % 360;

            while (angle < 0)
            {
                angle += 360;
            }
            return angle;
        }

        static linelatlng findClosestLine(utmpos start, List<linelatlng> list, double minDistance, double angle)
        {
            if (minDistance == 0)
            {
                linelatlng answer = list[0];
                double shortest = double.MaxValue;

                foreach (linelatlng line in list)
                {
                    double ans1 = start.GetDistance(line.p1);
                    double ans2 = start.GetDistance(line.p2);
                    utmpos shorterpnt = ans1 < ans2 ? line.p1 : line.p2;

                    if (shortest > start.GetDistance(shorterpnt))
                    {
                        answer = line;
                        shortest = start.GetDistance(shorterpnt);
                    }
                }

                return answer;
            }


            // By now, just add 5.000 km to our lines so they are long enough to allow intersection
            double METERS_TO_EXTEND = 5000;

            double perperndicularOrientation = AddAngle(angle, 90);

            // Calculation of a perpendicular line to the grid lines containing the "start" point
            /*
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  -------------------------------------start---------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             */
            utmpos start_perpendicular_line = newpos(start, perperndicularOrientation, -METERS_TO_EXTEND);
            utmpos stop_perpendicular_line = newpos(start, perperndicularOrientation, METERS_TO_EXTEND);

            // Store one intersection point per grid line
            Dictionary<utmpos, linelatlng> intersectedPoints = new Dictionary<utmpos, linelatlng>();
            // lets order distances from every intersected point per line with the "start" point
            Dictionary<double, utmpos> ordered_min_to_max = new Dictionary<double, utmpos>();

            foreach (linelatlng line in list)
            {
                // Calculate intersection point
                utmpos p = FindLineIntersectionExtension(line.p1, line.p2, start_perpendicular_line, stop_perpendicular_line);
                
                // Store it
                intersectedPoints[p] = line;

                // Calculate distances between interesected point and "start" (i.e. line and start)
                double distance_p = start.GetDistance(p);

                if (!ordered_min_to_max.ContainsKey(distance_p))
                    ordered_min_to_max.Add(distance_p, p);
            }
     
            // Acquire keys and sort them.
            List<double> ordered_keys = ordered_min_to_max.Keys.ToList();
            ordered_keys.Sort();

            // Lets select a line that is the closest to "start" point but "mindistance" away at least.
            // If we have only one line, return that line whatever the minDistance says
            double key = double.MaxValue;
            int i = 0;
            while (key == double.MaxValue && i < ordered_keys.Count)
            {
                if (ordered_keys[i] >= minDistance)
                    key = ordered_keys[i];
                i++;
            }

            // If no line is selected (because all of them are closer than minDistance, then get the farest one
            if (key == double.MaxValue)
                key = ordered_keys[ordered_keys.Count-1];

            var filteredlist = intersectedPoints.Where(a => a.Key.GetDistance(start) >= key);

            return findClosestLine(start, filteredlist.Select(a => a.Value).ToList(), 0, angle);
        }

        static bool PointInPolygon(utmpos p, List<utmpos> poly)
        {
            utmpos p1, p2;
            bool inside = false;

            if (poly.Count < 3)
            {
                return inside;
            }
            utmpos oldPoint = new utmpos(poly[poly.Count - 1]);

            for (int i = 0; i < poly.Count; i++)
            {

                utmpos newPoint = new utmpos(poly[i]);

                if (newPoint.y > oldPoint.y)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.y < p.y) == (p.y <= oldPoint.y)
                    && ((double)p.x - (double)p1.x) * (double)(p2.y - p1.y)
                    < ((double)p2.x - (double)p1.x) * (double)(p.y - p1.y))
                {
                    inside = !inside;
                }
                oldPoint = newPoint;
            }
            return inside;
        }



    }
}
