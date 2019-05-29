using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICPackaging
{
    public partial class JitterAnalysis : Form
    {
        public JitterAnalysis()
        {
            InitializeComponent();
        }

        private void JitterAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void FIRButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" For a bit pattern ..10100101101010... the following fir taps: precurser: generates a precursor pulse = tap weight*inputamplitude mV = (0.0833*.8v). The post cursor pulse = tap weight*inputamplitude mv = (.666*0.8)v, the second post cursor pulse is -0.1667*.8v, the third pulse is 0.0833*0.8v","FIR Pulse");
        }

        private void Equalization_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The system is a series of filters including the equalizer, The equalizer is a technique to counter the low pass"+ 
"effect of the Xmission line.  Ideal interconnects are free of phase and amplitude distortion.For a bit pattern with momentum 10100101101010 the high frequency components"+
 "get attenuated more severly than the low frequency dc components. For fast bit patters, the time it takes for the interconnect to achieve the"+
"required voltage is greater than the switching rate of the transmitter.This is called intersymbol interference.The equalizer should counter the low"+
"pass effect of the interconnect which causes the high frequency signal content to be attenuated more severly than the low frequency content. An example of an active equalizer is just a high pass filter(RC filter) connected to an amplifier", "What is Equalization");

        }

        private void CTLE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's a first order high pass filter with an amplifier","Active CTLE");


        }

        private void FFE_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Equalizing channels that exhibit a wide variation in pcb lengths or data rates or other frequency dependent loss parameters require that the equalizer design contain the flexibility to set the equalizer coefficients adaptively to minimize the ISI, such an equalizer is called the adaptive equalizer. A user defined sequence is not utilized for the adaptive equalizer. ", "Feed forward linear equalizer with adaptive equalizer FFE");

        }

        private void DFE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The decision feedback equalizer a non-linear filter that uses previously detected symbols to subtract ISI from the input stream. It uses a feedforward filter with a feedback filter.  The input of the feedback filter is the sequence of decisions from previously detected symbols which it uses to remove the ISI caused by those symbols. Hence it can only remove post cursor ISI. Another limitation of the DFE is that it assumes that the past symbol decisions are correct. Adding the DLE on the front end reduces the probability of error. ", "Decision Feedback Equalizer ");

        }

        private void BER_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The probability of receiving erroneous bit which is known a the bit error rate (BER) or bit error ratio. The BER is the ratio of the # of erroneous received bits to the total # of transmitted bits over a long interval", "Bit Error Rate");
        }
    }
}
