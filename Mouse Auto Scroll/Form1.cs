using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Auto_Scroll
{  
    public partial class Form1 : Form
    {
        #region Dll Imports

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);        
        const uint MOUSEEVENTF_WHEEL = 0x0800;


        private MOUSEINPUT createMouseInput(int x, int y, uint data, uint t, uint flag)
        {
            MOUSEINPUT mi = new MOUSEINPUT();
            
            mi.mouseData = data;
            
            mi.dwFlags =  MOUSEEVENTF_WHEEL;            
            return mi;
        }


        #endregion

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        //...

        Process p; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (txtScrollPerSecond.Text != String.Empty)
            {
                if (cmbxCurrentProcesses.Text != string.Empty)
                {
                    
                    double enteredValue = double.Parse(txtScrollPerSecond.Text, System.Globalization.CultureInfo.InvariantCulture);
                    TimeSpan ts = TimeSpan.FromSeconds(enteredValue);
                    tmrMouseScrollTimer.Interval = (int)ts.TotalMilliseconds;
                    if (tmrMouseScrollTimer.Enabled == false)
                        tmrMouseScrollTimer.Start();
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { if (e == null)
                return;
            else if(e.KeyCode == Keys.F8)
            {
                tmrMouseScrollTimer.Stop();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            tmrMouseScrollTimer.Stop();
        }

        private bool FormNotActive()
        {
            if( Form1.ActiveForm != this)
            return true;
            else
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> processList = new List<string>();
            
            foreach(Process proc in Process.GetProcesses())
            {
                processList.Add(proc.ProcessName);                
            }

            processList.Sort();
            foreach(string process in processList)
            {
                cmbxCurrentProcesses.Items.Add(process);
            }
        }

        private void tmrMouseScrollTimer_Tick(object sender, EventArgs e)
        {
            p = Process.GetProcessesByName(cmbxCurrentProcesses.Text).FirstOrDefault();
            if (p.ProcessName == string.Empty)
            {
                tmrMouseScrollTimer.Stop();
                MessageBox.Show("An error Occurred while getting the window specified");
                return;
            }
            
            INPUT[] inp = new INPUT[2];
            inp[0].mi = createMouseInput(0, 0, 50, 0, MOUSEEVENTF_WHEEL);
            SendInput((uint)inp.Length, inp, Marshal.SizeOf(inp[0].GetType()));
            if (Control.ModifierKeys == Keys.F8)
                tmrMouseScrollTimer.Stop();
           
        }
    }
}
