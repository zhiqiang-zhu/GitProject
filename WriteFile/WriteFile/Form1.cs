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

            string s2 = "<tr>	<td rowspan=\"7\">路面工程</td>	<td colspan=\"2\">路面裂缝（m）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">路面坑槽（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">网裂（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">网篦缺失（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">排水沟破损（m）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>" +
                        "<tr>	<td colspan=\"2\">伸缩缝破损（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

            string s3 = "<tr>	<td rowspan=\"7\">机电设施</td>	<td colspan=\"2\">疏散指示牌破损（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">灭火器缺失或失效（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防玻璃破损（块）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防水带缺失（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">消防栓压力超标（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">电话室门损坏（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">照明灯损坏（个）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

            string s4 = "<tr>	<td rowspan=\"3\">洞门及防护</td>	<td colspan=\"2\">护坡破损（m&sup2）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">洞门瓷砖脱落（块）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>"+
                        "<tr>	<td colspan=\"2\">排水沟堵塞（处）</td>	<td>January</td>	<td>$100</td>	<td>$100</td>  </tr>";

            string totalString = "<table border=\"1px\" cellspacing=\"0\" align=\"center\"><caption>表1蛇家坡隧道病害统计表</caption>" + s1 + s2 + s3 + s4 + "</table>";
            string strwritedata = textBox1.Text;
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
