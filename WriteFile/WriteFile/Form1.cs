using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WriteFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tunnelName = "蛇家坡";
            int a = 100, b = 200, c = 300;
            /*
            string s1 = "<tr>	<th colspan=\"3\"></th><th>蛇家坡隧道右幅</th><th>蛇家坡隧道左幅</th><th>合计</th>  </tr>"+
                        "<tr>    <td rowspan=\"10\">土建工程</td>	<td rowspan=\"2\">纵向裂缝</td>	<td>宽度< 0.20mm</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td>宽度≧0.20mm</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td rowspan=\"2\">环向裂缝</td>	<td>宽度< 0.20mm</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td>宽度≧0.20mm</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">剥落（m&sup2）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">网裂（m&sup2）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">渗水泛碱（m&sup2）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">机械划痕（m&sup2）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">检修道盖板破损（m&sup2）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>"+
                        "<tr>    <td colspan=\"2\">检修道盖板损坏或缺失（个）</td>	<td>$100</td>	<td>January</td>	<td>$100</td>  </tr>";

             */
         
            string s11 = String.Format("<tr>	<th colspan=\"3\"></th><th>{0}隧道右幅</th><th>{1}隧道左幅</th><th>合计</th>  </tr>",tunnelName,tunnelName);
            string s12 = String.Format("<tr>    <td rowspan=\"10\">土建工程</td>	<td rowspan=\"2\">纵向裂缝</td>	<td>宽度< 0.20mm</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s13 = String.Format("<tr>    <td>宽度≧0.20mm</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s14 = String.Format("<tr>    <td rowspan=\"2\">环向裂缝</td>	<td>宽度< 0.20mm</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s15 = String.Format("<tr>    <td>宽度≧0.20mm</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s16 = String.Format("<tr>    <td colspan=\"2\">剥落（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s17 = String.Format("<tr>    <td colspan=\"2\">网裂（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s18 = String.Format("<tr>    <td colspan=\"2\">渗水泛碱（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s19 = String.Format("<tr>    <td colspan=\"2\">机械划痕（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s110 = String.Format("<tr>    <td colspan=\"2\">检修道盖板破损（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s111 = String.Format("<tr>    <td colspan=\"2\">检修道盖板损坏或缺失（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);

            string s1 = s11 + s12 + s13 + s14 + s15 + s16 + s17 + s18 + s19 + s110 + s111;

            /*
            string s2 = "<tr>	<td rowspan=\"7\">路面工程</td>	<td colspan=\"2\">路面裂缝（m）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">路面坑槽（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">网裂（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">网篦缺失（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">排水沟破损（m）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">伸缩缝破损（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

             */
            


            string s21 = String.Format("<tr>	<td rowspan=\"7\">路面工程</td>	<td colspan=\"2\">路面裂缝（m）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s22 = String.Format("<tr>	<td colspan=\"2\">路面坑槽（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s23 = String.Format("<tr>	<td colspan=\"2\">网裂（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s24 = String.Format("<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s25 = String.Format("<tr>	<td colspan=\"2\">网篦缺失（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s26 = String.Format("<tr>	<td colspan=\"2\">排水沟破损（m）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s27 = String.Format("<tr>	<td colspan=\"2\">伸缩缝破损（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);

            string s2 = s21 + s22 + s23 + s24 + s25 + s26 + s27;


            /*
            string s3 = "<tr>	<td rowspan=\"7\">机电设施</td>	<td colspan=\"2\">疏散指示牌破损（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">灭火器缺失或失效（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防玻璃破损（块）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防水带缺失（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防栓压力超标（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">电话室门损坏（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">照明灯损坏（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

            */

            string s31 = String.Format("<tr>	<td rowspan=\"7\">机电设施</td>	<td colspan=\"2\">疏散指示牌破损（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s32 = String.Format("<tr>	<td colspan=\"2\">灭火器缺失或失效（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s33 = String.Format("<tr>	<td colspan=\"2\">消防玻璃破损（块）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s34 = String.Format("<tr>	<td colspan=\"2\">消防水带缺失（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s35 = String.Format("<tr>	<td colspan=\"2\">消防栓压力超标（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s36 = String.Format("<tr>	<td colspan=\"2\">电话室门损坏（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>",a,b,c);
            string s37 = String.Format("<tr>	<td colspan=\"2\">照明灯损坏（个）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>", a, b, c);

            string s3 = s31 + s32 + s33 + s34 + s35 + s36 + s37;


            /*
            string s4 = "<tr>	<td rowspan=\"3\">洞门及防护</td>	<td colspan=\"2\">护坡破损（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">洞门瓷砖脱落（块）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

            */
            string s41 = String.Format("<tr>	<td rowspan=\"3\">洞门及防护</td>	<td colspan=\"2\">护坡破损（m&sup2）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>", a, b, c);
            string s42 = String.Format("<tr>	<td colspan=\"2\">洞门瓷砖脱落（块）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>", a, b, c);
            string s43 = String.Format("<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>{0}</td>	<td>{1}</td>	<td>{2}</td>  </tr>", a, b, c);
            string s4 = s41 + s42 + s43;


            string totalString = String.Format("<table border=\"1px\" cellspacing=\"0\" align=\"center\"><caption>表1{0}隧道病害统计表</caption>" + s1 + s2 + s3 + s4 + "</table>", tunnelName);
            //string totalString = "<table border=\"1px\" cellspacing=\"0\" align=\"center\"><caption>表1蛇家坡隧道病害统计表</caption>" + s1 + s2 + s3 + s4 + "</table>";
           
            try
            {
                using(FileStream fs=new FileStream(textBox2.Text,FileMode.Create))
                {
                    byte[] arrwritedata = Encoding.Default.GetBytes(totalString);
                    fs.Write(arrwritedata, 0, arrwritedata.Length);
                    MessageBox.Show("写入文本成功！！！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常" + ex.Message);
            }
        }
    }
}
