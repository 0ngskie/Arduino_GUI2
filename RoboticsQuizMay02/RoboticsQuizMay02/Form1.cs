using System;
using System.Windows.Forms;

namespace RoboticsQuizMay02
{
    public partial class Robotics_Arduino_GUI2 : Form
    {
        private string blueLEDValue;
        private Boolean blueChkValue = false;

        private string redLEDValue;
        private Boolean redChkValue = false;

        private string yellowLEDValue;
        private Boolean yellowChkValue = false;

        private string emergencyVal;
        private Boolean emergencyChkValue = false;

        private string nukeVal;
        private Boolean nukeChkValue = false;

        private string policeVal;
        private Boolean policeChkValue = false;

        public Robotics_Arduino_GUI2()
        {
            InitializeComponent();
            serialPort1.Open();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ServoTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void ApplyServoBT_Click(object sender, EventArgs e)
        {
            string apply = "A" + ServoTB.Text;
            serialPort1.Write(apply);

        }
        private void resetServoBT_Click(object sender, EventArgs e)
        {
            ServoTB.Clear();
            serialPort1.Write("0");
        }
        private void ledBrightnessTB_Scroll(object sender, EventArgs e)
        {
            blueLEDValue = "B" + ledBrightnessTB.Value;
            redLEDValue = "R" + ledBrightnessTB.Value;
            yellowLEDValue = "Y" + ledBrightnessTB.Value;
            if (blueLEDChkBox.Checked)
            {
                serialPort1.Write(blueLEDValue);
            }
            if (redLEDChckBox.Checked) 
            {
                serialPort1.Write(redLEDValue);
            }
            if (yellowLEDChckBox.Checked)
            {
                serialPort1.Write(yellowLEDValue);
            }

        }

        private void blueLEDChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blueLEDChkBox.Checked)
            {
                blueChkValue = true;
            }
        }

        private void redLEDChckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redLEDChckBox.Checked)
            {
                redChkValue = true;
            }
        }

        private void yellowLEDChckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowLEDChckBox.Checked)
            {
                yellowChkValue = true;
            }
        }

        private void staticRB_CheckedChanged(object sender, EventArgs e)
        {
            if (staticRB.Checked)
            {
                serialPort1.Write("S");
            }
        }

        private void blinkLEDRB_CheckedChanged(object sender, EventArgs e)
        {
            if (blinkLEDRB.Checked)
            {
                serialPort1.Write("L");
            }
        }

        private void ledConfirmBT_Click(object sender, EventArgs e)
        {
            if (blueChkValue == false)
            {
                blueLEDValue = "B0";
            }
            if (blueLEDChkBox.Checked)
            {
                serialPort1.Write(blueLEDValue);
            }           
        }
        private void redConfirmBT_Click(object sender, EventArgs e)
        {
            if (redChkValue == false)
            {
                redLEDValue = "R0";
            }
            if (redLEDChckBox.Checked) 
            {
                serialPort1.Write(redLEDValue);
            }           
        }
        private void yellowConfirmBT_Click(object sender, EventArgs e)
        {
            if (yellowChkValue == false)
            {
                yellowLEDValue = "Y0";
            }
            if (yellowLEDChckBox.Checked)
            {
                serialPort1.Write(yellowLEDValue);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buzzerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = buzzerCB.Text;

            if (buzzerCB.Text.Equals("Emergency"))
            {
                emergencyVal = "E" + buzzerCB.SelectedIndex;
                emergencyChkValue = true;
            };

            if (buzzerCB.Text.Equals("Police Siren"))
            {
                policeVal = "P" + buzzerCB.SelectedIndex;
                policeChkValue = true;
            };
        }

        private void playBuzzerBT_Click(object sender, EventArgs e)
        {
            if (emergencyChkValue == true) 
            {
                serialPort1.Write(emergencyVal);
            };
            
            if(policeChkValue == true)
            {
                serialPort1.Write(policeVal);
            };
        }

        private void stopBuzzerBT_Click(object sender, EventArgs e)
        {
            emergencyChkValue = false;
            nukeChkValue = false;
            policeChkValue = false;

            if(emergencyChkValue == false)
            {
                emergencyVal = "E0";
            };
            
            if(policeChkValue == false)
            {
                policeVal = "P0";
            }
        }
    }
}
