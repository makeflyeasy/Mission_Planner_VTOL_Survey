using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ZedGraph;
using MissionPlanner.Utilities;
using GMap.NET.WindowsForms;
using System.IO;
using System.Threading;
using MissionPlanner.Log;


using System.Globalization;

using System.Runtime.InteropServices;
using uint8_t = System.Byte;

namespace MissionPlanner
{
    public partial class Form1 : Form

    {
        CollectionBuffer logdata;
        Hashtable logdatafilter = new Hashtable();

        List<TextObj> ModeCache = new List<TextObj>();
        List<TextObj> ModePolyCache = new List<TextObj>();
        List<TextObj> MSGCache = new List<TextObj>();
        List<TextObj> ErrorCache = new List<TextObj>();
        List<TextObj> TimeCache = new List<TextObj>();
        DFLog.DFItem[] gpscache = new DFLog.DFItem[0];

        List<PointPairList> listdata = new List<PointPairList>();
        DFLog dflog;
        public string logfilename;
        private static string lastLogDir;
        public Form1()
        {
            InitializeComponent();

        }

        string file;
        
        private void myButton1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Minimum = 0;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
               DataTable dataTable = new DataTable("dataTable");
                dataGridView1.Columns.Clear ();
                dataTable.Columns.Add("序号", typeof(string));
                dataTable.Columns.Add("TimeUS", typeof(string));
                dataTable.Columns.Add("GPS时间", typeof(string));
                dataTable.Columns.Add("GPSweek", typeof(string));
                dataTable.Columns.Add("纬度", typeof(string));
                dataTable.Columns.Add("经度", typeof(string));
                dataTable.Columns.Add("高度", typeof(string));
                dataTable.Columns.Add("真实高度", typeof(string));
                dataTable.Columns.Add("GPS高度", typeof(string));
                dataTable.Columns.Add("Roll", typeof(string));
                dataTable.Columns.Add("Pitch", typeof(string));
                dataTable.Columns.Add("Yaw", typeof(string));
                
                ofd.Filter = "Binary Log|*.bin;*.BIN";
                ofd.Multiselect = true;

                ofd.ShowDialog();
               
                 file = Path.GetDirectoryName(ofd.FileName ) + Path.DirectorySeparatorChar +
                Path.GetFileNameWithoutExtension(ofd.FileName) + ".log";
          
                foreach (string logfile in ofd.FileNames)
                    {
                    string outfilename = Path.GetDirectoryName(logfile) + Path.DirectorySeparatorChar +
                                         Path.GetFileNameWithoutExtension(logfile) + ".log";

                    ConvertBini(logfile, outfilename);
                                   
                     }

                int i = 0;
                StreamReader sr = new StreamReader(file);
                int Length = (int )sr.BaseStream.Length;
                while (sr.BaseStream.Position < Length)
                {
                    string strRead = sr .ReadLine();
                    int index = strRead.IndexOf("CAM, ");
                    
                    int index1= strRead.IndexOf("CAM, Q");
                    
                    //strRead=strRead.Replace("CAM", i.ToString ());i++;
                    if (index>-1&& index1 == -1)
                    {
                        strRead = strRead.Replace("CAM", i.ToString()); i++;
                        //dataTable.Rows.Add(strRead.Split(' '));
                        string[] data = strRead.Split(',');
                        DataRow dr = dataTable.NewRow();
                        dr[0] = data[0];
                        dr[1] = data[1];
                        dr[2] = data[2];
                        dr[3] = data[3];
                        dr[4] = data[4];
                        dr[5] = data[5];
                        dr[6] = data[6];
                        dr[7] = data[7];
                        dr[8] = data[8];
                        dr[9] = data[9];
                        dr[10] = data[10];
                        dr[11] = data[11];
                        //将这行数据加入到datatable中
                        dataTable.Rows.Add(dr);
                       
                    }
                    progressBar1.Value = 50+(int )(sr.BaseStream.Position / (float)Length/2*100);
                }
                this.dataGridView1.DataSource = dataTable;
              
                //this.dataGridView1.RowHeadersVisible = false;
                sr.Close ();
                label1.Text = "统计" + i;
               



            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Minimum = 0;
            DataTable dataTable = new DataTable("dataTable");
            //dataGridView1.Columns.Clear();
            dataTable.Columns.Add("序号", typeof(string));
            dataTable.Columns.Add("照片名称", typeof(string));
            dataTable.Columns.Add("GPS时间", typeof(string));
            dataTable.Columns.Add("GPSweek", typeof(string));
            dataTable.Columns.Add("纬度", typeof(string));
            dataTable.Columns.Add("经度", typeof(string));
            dataTable.Columns.Add("高度", typeof(string));
            dataTable.Columns.Add("真实高度", typeof(string));
            dataTable.Columns.Add("GPS高度", typeof(string));
            dataTable.Columns.Add("Roll", typeof(string));
            dataTable.Columns.Add("Pitch", typeof(string));
            dataTable.Columns.Add("Yaw", typeof(string));
            int i = 0;
            StreamReader sr = new StreamReader(file);
            int Length = (int)sr.BaseStream.Length;
            while (sr.BaseStream.Position < Length)
            {
                string strRead = sr.ReadLine();
                
                int index = strRead.IndexOf("CAM, ");
                
                int index1 = strRead.IndexOf("CAM, Q");

                //strRead=strRead.Replace("CAM", i.ToString ());i++;
                if (index > -1 && index1 == -1)
                {
                    strRead = strRead.Remove(5,10);
                    strRead = strRead.Insert(5,textBox1 .Text + (int.Parse(textBox3.Text)+i).ToString().PadLeft(3, '0') + "."+textBox2 .Text+"," );
                    strRead = strRead.Replace(",,",",");
                    strRead = strRead.Replace("CAM", i.ToString()); i++;

                    //dataTable.Rows.Add(strRead.Split(' '));
                     string[] data = strRead.Split(',');
                    DataRow dr = dataTable.NewRow();
                    dr[0] = data[0];
                    dr[1] = data[1];
                    dr[2] = data[2];
                    dr[3] = data[3];
                    dr[4] = data[4];
                    dr[5] = data[5];
                    dr[6] = data[6];
                    dr[7] = data[7];
                    dr[8] = data[8];
                    dr[9] = data[9];
                    dr[10] = data[10];
                    try { 
                    dr[11] = data[11];
                        }
                    catch { }
                    //将这行数据加入到datatable中
                    dataTable.Rows.Add(dr);

                }
                progressBar1.Value = (int)(sr.BaseStream.Position / (float)Length  * 100);
            }
            this.dataGridView2.DataSource = dataTable;

            //this.dataGridView1.RowHeadersVisible = false;
            sr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "output1.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            sb.Append(cell.FormattedValue);
                            sb.Append(',');
                        }
                        sw.WriteLine(sb.ToString());
                    }
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Size = new System.Drawing.Size(this .Width -180, this.Height / 2);
            this.dataGridView2.Location = new System.Drawing.Point(143, this.Height/2);
            this.dataGridView2.Size = new System.Drawing.Size(this.Width - 180, this.Height / 2-50);
        }

        /*private void Form1_Resize(object sender, EventArgs e)
        {

            this.dataGridView1.Size = new System.Drawing.Size(848, this.Height /2);
        }*/

        public const byte HEAD_BYTE1 = 0xA3; // Decimal 163  
        public const byte HEAD_BYTE2 = 0x95; // Decimal 149  

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct log_Format
        {
            public uint8_t type;
            public uint8_t length;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public byte[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public byte[] format;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] public byte[] labels;
        }

        public struct log_format_cache
        {
            public uint8_t type;
            public uint8_t length;
            public string name;
            public string format;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UnionArray
        {
            public UnionArray(byte[] bytes)
            {
                this.Shorts = null;
                this.Bytes = bytes;
            }

            [FieldOffset(0)]
            public byte[] Bytes;

            [FieldOffset(0)]
            public short[] Shorts;

            public override string ToString()
            {
                return "[" + String.Join(" ", Shorts.Take((Bytes.Length / 2)).ToList()) + "]";
            }
        }

        object locker = new object();

        Dictionary<string, log_Format> logformat = new Dictionary<string, log_Format>();

        public static event getFlightMode onFlightMode;

        public delegate string getFlightMode(string firmware, int modeno);


         void  ConvertBini(string inputfn, string outputfn, Action<int> progress = null)
        {
            using (var stream = File.Open(outputfn, FileMode.Create))
            {
                using (BinaryReader br = new BinaryReader(new BufferedStream(File.OpenRead(inputfn), 1024 * 1024)))
                {
                    DateTime displaytimer = DateTime.MinValue;

                    var length = br.BaseStream.Length;

                    while (br.BaseStream.Position < length)
                    {
                        if (displaytimer.Second != DateTime.Now.Second)
                        {
                            if (progress != null)
                                progress((int)((br.BaseStream.Position / (float)br.BaseStream.Length) * 100));

                            Console.WriteLine("ConvertBin " + (br.BaseStream.Position / (float)br.BaseStream.Length) * 100);
                            displaytimer = DateTime.Now;
                        }
                        byte[] data = ASCIIEncoding.ASCII.GetBytes(ReadMessage(br.BaseStream, length));
                        stream.Write(data, 0, data.Length);

                        progressBar1.Value = 
                          (int )(br.BaseStream.Position / (float)br.BaseStream.Length / 2*100);
                        //progressBar1.Value = (int)(a*100);
                    }
                }
            }
        }




        private string _firmware = "";

        public string ReadMessage(Stream br, long length)
        {
            lock (locker)
            {
                int log_step = 0;

                while (br.Position < length)
                {
                    byte data = (byte)br.ReadByte();

                    switch (log_step)
                    {
                        case 0:
                            if (data == HEAD_BYTE1)
                            {
                                log_step++;
                            }
                            break;

                        case 1:
                            if (data == HEAD_BYTE2)
                            {
                                log_step++;
                            }
                            else
                            {
                                log_step = 0;
                            }
                            break;

                        case 2:
                            log_step = 0;
                            try
                            {
                                string line = String.Join(", ", logEntryObjects(data, br).Select((a) =>
                                {
                                    if (a.IsNumber())
                                        return (((IConvertible)a).ToString(CultureInfo.InvariantCulture));
                                    else
                                        return a.ToString();
                                })) + "\r\n";

                                // we need to know the mav type to use the correct mode list.
                                if (line.Contains("PARM, RATE_RLL_P") || line.Contains("ArduCopter") ||
                                    line.Contains("Copter"))
                                {
                                    _firmware = "ArduCopter2";
                                }
                                else if ((line.Contains("PARM, H_SWASH_PLATE")) || line.Contains("ArduCopter"))
                                {
                                    _firmware = "ArduCopter2";
                                }
                                else if (line.Contains("PARM, PTCH2SRV_P") || line.Contains("ArduPlane") ||
                                         line.Contains("Plane"))
                                {
                                    _firmware = "ArduPlane";
                                }
                                else if (line.Contains("PARM, SKID_STEER_OUT") || line.Contains("ArduRover") ||
                                         line.Contains("Rover"))
                                {
                                    _firmware = "ArduRover";
                                }
                                else if (line.Contains("AntennaTracker") || line.Contains("Tracker"))
                                {
                                    _firmware = "ArduTracker";
                                }

                                return line;
                            }
                            catch
                            {
                                Console.WriteLine("Bad Binary log line {0}", data);
                            }
                            break;
                    }
                }

                return "";
            }
        }


        internal (byte MsgType, long Offset) ReadMessageTypeOffset(Stream br, long length)
        {
            int log_step = 0;

            while (br.Position < length)
            {
                byte data = (byte)br.ReadByte();

                switch (log_step)
                {
                    case 0:
                        if (data == HEAD_BYTE1)
                        {
                            log_step++;
                        }

                        break;

                    case 1:
                        if (data == HEAD_BYTE2)
                        {
                            log_step++;
                        }
                        else
                        {
                            log_step = 0;
                        }

                        break;

                    case 2:
                        log_step = 0;
                        try
                        {
                            long pos = br.Position - 3;
                            // read fmt or seek length of packet
                            logEntryFMT(data, br);

                            return (data, pos);
                        }
                        catch
                        {
                            Console.WriteLine("Bad Binary log line {0}", data);
                        }

                        break;
                }
            }

            return (0, 0);

        }

        void logEntryFMT(byte packettype, Stream br)
        {
            switch (packettype)
            {
                case 0x80: // FMT

                    log_Format logfmt = new log_Format();

                    object obj = logfmt;

                    int len = Marshal.SizeOf(obj);

                    byte[] bytearray = new byte[len];

                    br.Read(bytearray, 0, bytearray.Length);

                    IntPtr i = Marshal.AllocHGlobal(len);

                    // create structure from ptr
                    obj = Marshal.PtrToStructure(i, obj.GetType());

                    // copy byte array to ptr
                    Marshal.Copy(bytearray, 0, i, len);

                    obj = Marshal.PtrToStructure(i, obj.GetType());

                    Marshal.FreeHGlobal(i);

                    logfmt = (log_Format)obj;

                    string lgname = ASCIIEncoding.ASCII.GetString(logfmt.name).Trim(new char[] { '\0' });
                    //string lgformat = ASCIIEncoding.ASCII.GetString(logfmt.format).Trim(new char[] {'\0'});
                    //string lglabels = ASCIIEncoding.ASCII.GetString(logfmt.labels).Trim(new char[] {'\0'});

                    logformat[lgname] = logfmt;

                    packettypecache[logfmt.type] = new log_format_cache()
                    {
                        length = logfmt.length,
                        type = logfmt.type,
                        name = ASCIIEncoding.ASCII.GetString(logfmt.name).Trim(new char[] { '\0' }),
                        format = ASCIIEncoding.ASCII.GetString(logfmt.format).Trim(new char[] { '\0' }),
                    };

                    return;

                default:
                    //string format = "";
                    //string name = "";

                    int size = 0;

                    if (packettypecache[packettype].length != 0)
                    {
                        var fmt = packettypecache[packettype];
                        //name = fmt.name;
                        //format = fmt.format;
                        size = fmt.length;
                    }

                    // didnt find a match, return unknown packet type
                    if (size == 0)
                        return;

                    //byte[] buf = new byte[size - 3];
                    //br.Read(buf, 0, buf.Length);

                    br.Seek(br.Position + size - 3, SeekOrigin.Begin);
                    break;
            }
        }

        public object[] ReadMessageObjects(Stream br, long length)
        {
            lock (locker)
            {
                int log_step = 0;

                while (br.Position < length)
                {
                    byte data = (byte)br.ReadByte();

                    switch (log_step)
                    {
                        case 0:
                            if (data == HEAD_BYTE1)
                            {
                                log_step++;
                            }
                            break;

                        case 1:
                            if (data == HEAD_BYTE2)
                            {
                                log_step++;
                            }
                            else
                            {
                                log_step = 0;
                            }
                            break;

                        case 2:
                            log_step = 0;
                            try
                            {
                                var line = logEntryObjects(data, br);

                                return line;
                            }
                            catch
                            {
                                Console.WriteLine("Bad Binary log line {0}", data);
                            }
                            break;
                    }
                }

                return null;
            }
        }

        object[] logEntryObjects(byte packettype, Stream br)
        {
            lock (locker)
            {
                switch (packettype)
                {
                    case 0x80: // FMT

                        log_Format logfmt = new log_Format();

                        object obj = logfmt;

                        int len = Marshal.SizeOf(obj);

                        byte[] bytearray = new byte[len];

                        br.Read(bytearray, 0, bytearray.Length);

                        IntPtr i = Marshal.AllocHGlobal(len);

                        // create structure from ptr
                        obj = Marshal.PtrToStructure(i, obj.GetType());

                        // copy byte array to ptr
                        Marshal.Copy(bytearray, 0, i, len);

                        obj = Marshal.PtrToStructure(i, obj.GetType());

                        Marshal.FreeHGlobal(i);

                        logfmt = (log_Format)obj;

                        string lgname = ASCIIEncoding.ASCII.GetString(logfmt.name).Trim(new char[] { '\0' });
                        string lgformat = ASCIIEncoding.ASCII.GetString(logfmt.format).Trim(new char[] { '\0' });
                        string lglabels = ASCIIEncoding.ASCII.GetString(logfmt.labels).Trim(new char[] { '\0' });

                        logformat[lgname] = logfmt;

                        return new object[] { "FMT", logfmt.type, logfmt.length, lgname, lgformat, lglabels };

                    default:
                        string format = "";
                        string name = "";
                        int size = 0;

                        if (packettypecache[packettype].length != 0)
                        {
                            var fmt = packettypecache[packettype];
                            name = fmt.name;
                            format = fmt.format;
                            size = fmt.length;
                        }
                        else
                        {
                            foreach (log_Format fmt in logformat.Values)
                            {
                                packettypecache[fmt.type] = new log_format_cache()
                                {
                                    length = fmt.length,
                                    type = fmt.type,
                                    name = ASCIIEncoding.ASCII.GetString(fmt.name).Trim(new char[] { '\0' }),
                                    format = ASCIIEncoding.ASCII.GetString(fmt.format).Trim(new char[] { '\0' }),
                                };

                                if (fmt.type == packettype)
                                {
                                    name = packettypecache[fmt.type].name;
                                    format = packettypecache[fmt.type].format;
                                    size = fmt.length;
                                    //break;
                                }
                            }
                        }

                        // didnt find a match, return unknown packet type
                        if (size == 0)
                            return null;

                        byte[] data = new byte[size - 3]; // size - 3 = message - messagetype - (header *2)

                        br.Read(data, 0, data.Length);

                        return ProcessMessageObjects(data, name, format);
                }
            }
        }

        private object[] ProcessMessageObjects(byte[] message, string name, string format)
        {
            char[] form = format.ToCharArray();

            int offset = 0;

            List<object> answer = new List<object>();

            answer.Add(name);

            foreach (char ch in form)
            {
                switch (ch)
                {
                    case 'b':
                        answer.Add((sbyte)message[offset]);
                        offset++;
                        break;
                    case 'B':
                        answer.Add(message[offset]);
                        offset++;
                        break;
                    case 'h':
                        answer.Add(BitConverter.ToInt16(message, offset));
                        offset += 2;
                        break;
                    case 'H':
                        answer.Add(BitConverter.ToUInt16(message, offset));
                        offset += 2;
                        break;
                    case 'i':
                        answer.Add(BitConverter.ToInt32(message, offset));
                        offset += 4;
                        break;
                    case 'I':
                        answer.Add(BitConverter.ToUInt32(message, offset));
                        offset += 4;
                        break;
                    case 'q':
                        answer.Add(BitConverter.ToInt64(message, offset));
                        offset += 8;
                        break;
                    case 'Q':
                        answer.Add(BitConverter.ToUInt64(message, offset));
                        offset += 8;
                        break;
                    case 'f':
                        answer.Add(BitConverter.ToSingle(message, offset));
                        offset += 4;
                        break;
                    case 'd':
                        answer.Add(BitConverter.ToDouble(message, offset));
                        offset += 8;
                        break;
                    case 'c':
                        answer.Add((BitConverter.ToInt16(message, offset) / 100.0));
                        offset += 2;
                        break;
                    case 'C':
                        answer.Add((BitConverter.ToUInt16(message, offset) / 100.0));
                        offset += 2;
                        break;
                    case 'e':
                        answer.Add((BitConverter.ToInt32(message, offset) / 100.0));
                        offset += 4;
                        break;
                    case 'E':
                        answer.Add((BitConverter.ToUInt32(message, offset) / 100.0));
                        offset += 4;
                        break;
                    case 'L':
                        answer.Add(((double)BitConverter.ToInt32(message, offset) / 10000000.0));
                        offset += 4;
                        break;
                    case 'n':
                        answer.Add(ASCIIEncoding.ASCII.GetString(message, offset, 4).Trim(new char[] { '\0' }));
                        offset += 4;
                        break;
                    case 'N':
                        answer.Add(ASCIIEncoding.ASCII.GetString(message, offset, 16).Trim(new char[] { '\0' }));
                        offset += 16;
                        break;
                    case 'M':
                        int modeno = message[offset];
                        string mode = onFlightMode?.Invoke(_firmware, modeno);
                        if (mode == null)
                            mode = modeno.ToString();
                        answer.Add(mode);
                        offset++;
                        break;
                    case 'Z':
                        answer.Add(ASCIIEncoding.ASCII.GetString(message, offset, 64).Trim(new char[] { '\0' }));
                        offset += 64;
                        break;
                    case 'a':
                        answer.Add(new UnionArray(message.Skip(offset).Take(64).ToArray()));
                        offset += 2 * 32;
                        break;
                    default:
                        return null;
                }
            }
            return answer.ToArray();
        }

        private log_format_cache[] packettypecache = new log_format_cache[256];

        /*  
    105    +Format characters in the format string for binary log messages  
    106    +  b   : int8_t  
    107    +  B   : uint8_t  
    108    +  h   : int16_t  
    109    +  H   : uint16_t  
    110    +  i   : int32_t  
    111    +  I   : uint32_t  
    112    +  f   : float  
         *     d   : double
    113    +  N   : char[16]  
    114    +  c   : int16_t * 100  
    115    +  C   : uint16_t * 100  
    116    +  e   : int32_t * 100  
    117    +  E   : uint32_t * 100  
    118    +  L   : uint32_t latitude/longitude  
    a : short[32]
    119    + */
    }
}
