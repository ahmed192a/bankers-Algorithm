using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankers_Algorithm
{
    struct process
    {
        public int id;
        public List<int> Max;            // 2D array Max[i,1] = k, means pi need max k instances of resource 1
        public List<int> Allocation; // 2D array Allocation[i,1] = k, means pi has k instances of resource 1
        public List<int> Need;           // 2D array Need[i,1] = k, means pi need k instances of resource 1 to start exec
    };
    public partial class Form1 : Form
    {
        static int nprocesses, nresources ;
        int count_alloc = 0, count_max = 0;
        List<int> seq = new List<int>();
        int[] available;              // num of instances for each resource
        List<process> processes = new List<process>();
        List<int> req = new List<int>();
        int choice = 1;
        int[][] Allocation;
        int[][] Max;
        public bool[] state;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_safe_CheckedChanged(object sender, EventArgs e)
        {
            choice = 1;
            label8.Visible = false;
            label9.Visible = false;
            text_Prequest.Visible = false;
            text_Rrequest.Visible = false;
            text_Prequest.Visible = false;

        }

        private void radioButton_request_CheckedChanged(object sender, EventArgs e)
        {
            choice = 2;
            label8.Visible = true;
            label9.Visible = true;
            text_Prequest.Visible = true;
            text_Rrequest.Visible = true;
            text_Prequest.Visible = true;
        }

        private void button_safe_Click(object sender, EventArgs e)
        {
            state = new bool[nprocesses];
            for (int i = 0; i < nprocesses; i++)
            {
                process p = new process();
                
                p.id = i;
                p.Allocation = Allocation[i].ToList<int>();
                p.Max = Max[i].ToList<int>();
                p.Need = new List<int>();
                for(int j = 0; j < nresources; j++)
                {
                    p.Need.Add( p.Max[j] - p.Allocation[j]);
                }
                processes.Add(p);
                state[i] = false;
            }
            
            available = Array.ConvertAll(text_available.Text.Split(' '), int.Parse);

            // print Need matrix
            rich_need.Clear();
            string n="";
            for(int j = -1; j < nprocesses; j++)
            {
                n = "";
                if(j == -1)
                {
                    n+= "  \t";
                    for (int i = 0; i < nresources; i++)
                    {
                        n+= "R" + i + "\t";
                    }
                    rich_need.AppendText(n+"\n");
                    continue;
                }
                n+= "P" + j + "\t";
                for (int i = 0; i < nresources; i++)
                    n+= processes[j].Need[i] + "\t";
                rich_need.AppendText(n + "\n");

            }
            string s = "";
            if (choice == 1)
            {
                if (IsSafe(processes, available))
                {
                    s = "Yes , Safe state <";
                    for (int i = 0; i < nprocesses; i++)
                    {

                        s = s + "P" + seq[i];
                        if (i != nprocesses - 1) s += ",";
                        else s += ">";
                    }
                    rich_output.AppendText(s + "\n");
                }
                else rich_output.AppendText("No\n");
            }
            else
            {
                int pp = 0;
                s = "";
                pp= int.Parse(text_Prequest.Text);
                req = Array.ConvertAll(text_Rrequest.Text.Split(' '), int.Parse).ToList<int>();

                if (Requset(processes, available, pp, req))
                {
                    s+= "Yes , Safe state <";
                    s+= "P" + pp + "req,";
                    for (int i = 0; i < nprocesses; i++)
                    {
                        s+= "P" + seq[i];
                        /*
						if(seq[i]==p) cout<<"P"<<seq[i]<<"req";
						else  cout<<"P"<<seq[i];
						*/
                        if (i != nprocesses - 1) s+= ",";
                        else s += ">";
                    }
                }
                else
                {
                    s+= "No";
                }
                rich_output.AppendText(s + "\n");
            }

        }

        private void button_max_Click(object sender, EventArgs e)
        {
            string s = text_max.Text;

            Max[count_max] = Array.ConvertAll(text_max.Text.Split(' '), int.Parse);
            rich_max.AppendText("P" + count_max + " -> " + s + "\n");
            text_max.Clear();
            count_max++;
            label5.Text = "Max matrix (" + (nprocesses - count_max) + ")";
            if (count_max == nprocesses)
            {
                text_max.Enabled = false;
                button_max.Enabled = false;
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            nprocesses = int.Parse(text_nprocess.Text);
            nresources = int.Parse(text_nresource.Text);
            count_alloc = 0;
            count_max = 0;
            label4.Text = "Allocation matrix (" + (nprocesses - count_max) + ")";
            label5.Text = "Max matrix (" + (nprocesses - count_alloc) + ")";
            text_allocation.Enabled = true;
            button_allocation.Enabled = true;
            text_available.Enabled = true;
            radioButton_request.Enabled = true;
            radioButton_safe.Enabled = true;
            text_max.Enabled = true;
            button_max.Enabled = true;

            text_nprocess.Enabled = false;
            text_nresource.Enabled = false;
            button_check.Enabled = false;


            Allocation = new int[nprocesses][];
            Max = new int[nprocesses][];
            /*
            for (int i = 0; i < nprocesses; i++)
            {
                Allocation[i] = new int[nresources];
            }
            */
        }

        private void button_allocation_Click(object sender, EventArgs e)
        {
          
            
            string s = text_allocation.Text;
            
            Allocation[count_alloc] = Array.ConvertAll(text_allocation.Text.Split(' '), int.Parse);
            rich_allocation.AppendText("P"+ count_alloc + " -> " + s + "\n");
            text_allocation.Clear();
            count_alloc++;
            label4.Text = "Allocation matrix (" + (nprocesses - count_alloc) + ")";
            if (count_alloc == nprocesses )
            {
                text_allocation.Enabled = false;
                button_allocation.Enabled = false;
            }
            
            
            
      

            //rich_allocation.AppendText(allocation.ToString()+"\n");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_allocation.Text = "";
            text_available.Text = "";
            text_max.Text = "";
            text_nprocess.Text = "";
            text_nresource.Text = "";
            text_Prequest.Text = "";
            text_Rrequest.Text = "";
            rich_allocation.Text = "";
            rich_max.Text = "";
            rich_need.Text = "";
            rich_output.Text = "";

            label5.Text = "Max matrix";
            label4.Text = "Allocation matrix";
            text_allocation.Enabled = false;
            button_allocation.Enabled = false;
            text_max.Enabled = false;
            button_max.Enabled = false;
            text_available.Enabled = false;

            text_nprocess.Enabled = true;
            text_nresource.Enabled = true;
            button_check.Enabled = true;

            radioButton_safe.Checked = true;
            radioButton_request.Checked = false;
            radioButton_request.Enabled = false;
            radioButton_safe.Enabled = false;

            // clear the data 
            processes.Clear();
            seq.Clear();
            req.Clear();



        }



        private bool Requset(List<process> processes, int[] available, int p, List<int> req)
        {
            int j;
            for (j = 0; j < nresources; j++)
                if (req[j] > available[j] || req[j] > processes[p].Need[j]) break;
            if (j != nresources) return false;
            for(int i  = 0; i < nprocesses; i++)
            {
                process pp = processes[0];
                processes.RemoveAt(0);
                if(pp.id == p)
                {
                    for (j = 0; j < nresources; j++)
                    {
                        pp.Allocation[j] += req[j];
                        pp.Need[j] -= req[j];
                        available[j] -= req[j];
                    }
                }
                processes.Add(pp);
            }

            /*
            int finished = nprocesses;
            while (finished != 0)
            {
                int counter = finished;
                foreach (var i in processes)
                {
                    if (state[i.id] == false)
                    {
                        for (j = 0; j < nresources; j++)
                            if (i.Need[j] > available[j]) break;
                        if (j == nresources)
                        {
                            finished--;
                            //processes[i.id].status = true;
                            state[i.id] = true;

                            for (int k = 0; k < nresources; k++)
                                available[k] += i.Allocation[k];
                            seq.Add(i.id);

                        }
                    }
                }
                if (counter == finished)
                {
                    return false;
                }

            }
            return true;
            */
            return IsSafe(processes, available);

        }

        private bool IsSafe(List<process> processes, int[] available)
        {

            int finished = nprocesses;
            int j = 0;
            while (finished != 0)
            {
                int counter = finished;
                foreach (var i in processes)
                {
                    if (state[i.id] == false)
                    {
                        for (j = 0; j < nresources; j++)
                            if (i.Need[j] > available[j]) break;
                        if (j == nresources)
                        {
                            finished--;
                            //processes[i.id].status = true;
                            state[i.id] = true;

                            for (int k = 0; k < nresources; k++)
                                available[k] += i.Allocation[k];
                            seq.Add(i.id);

                        }
                    }
                }
                if (counter == finished)
                {
                    return false;
                }

            }
            return true;

        }
    }
}
