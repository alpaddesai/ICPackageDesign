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
    public partial class ICPackaging : Form
    {
        public ICPackaging()
        {
            InitializeComponent();
        }

        private void ICPackaging_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PackageR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The resistance of the package leads is given by R= Resistivity * (length of the package lead / cross sectional area)", "Package Resistance");
        }

        private void PackageI_Click(object sender, EventArgs e)
        {
        MessageBox.Show("The inductance of the package leads depends on the permeability of the lead material and the lead geometry. The lead inductance can cause overshoot/undershoot in the signal lines, it can cause ground bounce due to simultaneous switching of the circuits and crosstalk between the signal lines due to mutual inductances between the leads","Package Inductance");
        }

        private void PackageC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The capacitance of the package leads depends on the lead geometry and the dielectric between the leads", "Package Capacitance");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CharacteristicImp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The characteristic impedance can be defined as the sqrt(L/C) where L and C are the inductance and capacitance per unit length of the package pins", "Characteristic Impedance");

        }

        private void ThermalResistance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The thermal resistance is the resistance of the package to heat dissipation,it is measured using the junction-to-ambient and junction-to-case thermal resistance values", "Thermal Resistance");

        }

        private void StressModel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Different materials have different coefficients of thermal expansion, this dissimilarity introduces mechanical stress in the attached components during operation. If stress exceeds the strength of the material it can initiate a crack. Thermal stress and moisture induced stress are important parameters which need to be considered when modelling IC packages", "IC Package Stress Modelling");

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PackageSimulation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As the frequency increases, the parasitic effects of the packages limits the performance of the IC and system. The self and mutual inductance along with coupling capacitance affects the signal quality and can introduce signal distortion and crosstalk problems", "Package Simulation");
            PictureBox5_Click(sender,e);
        }

        private void Timing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The voltage controlled resistor (Rp) for a CMOS inverter is a function length of the Xistor and inversely proportional to permeability, Cox, Vgs, Vtn, Vds and W ", "Delay in CMOS inverter");
            MessageBox.Show(" Delay of a CMOS inverster is the sum of the gate delay and interconnect delay, where the gate delay t1 = 0.69RpC1 where C1 is the load capacitor", "Delay in CMOS inverter at the 50% trip point");
            MessageBox.Show(" Input makes a high to low transition at the gate, C1 charges from zero to VDD from the pMOS transistor. At the 50% trip point, i.e Vout is 1/2 Vin, the time delay is 0.69 RpC1","Delay through the pMOS");
            MessageBox.Show(" Input makes a low to high transition at the gate, C1 charges from VDD to zero through the nMOS transistor. At the 50% trip point, i.e Vout is 1/2 Vin, the time delay is 0.69 RpC1", "Delay through the nMOS");

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void SPICE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Threshold voltage, Junction capacitance, oxide capacitance, Xsistor width, channel length, junction depth, oxide thickness,  Xsistor Transconductance,body factor, body doping, source drain doping  ", " SPICE parameters");

        }

        private void LoadCapacitor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" The total capacitor is the sum of the intrinsic capacitance ( pmos + nmos diffusion capacitance ) and the extrinisic capacitance (gate capacitance)  ", " Load Capacitor");

        }

        private void RiseFallTime_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" Rise time/Fall time at 20% to 80% trip point for the pMOS or an nMOS is 1.38RpC1 , Rise time is calculated through  the pMOS (VDD is high and Vin is zero), Fall time is calculated through the nNMOS", "Rise and Fall Time of the inverter");

            MessageBox.Show(" Rise time is directly proporational to the total load capacitance and inversely  proportional to the mobility of electrons or holes and Vdd (Vin at the gates of the inverter).  Since the mobility of holes is 1/2 of that of electrons and since the load capacitor charges from VDD to zero from the nMOS transistor" +
                " the fall time is half of the rise time for an inverter.  For equal rise/fall times with the same threshold voltage the channel width of the pMOS is 2.5x channel width of the nMOS", " Rise/Fall Time of the inverter");

        }

        private void LinearSaturation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The cutoff region is when Vgs<Vt, Ids =0, the linear region is when 0<Vds<Vgs-Vt, the saturation region is 0<Vgs-Vt<Vds","Linear Saturation Region");

        }

        private void NoiseMargin_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(" The Noise margin for an output low is the difference between the Vilmax and Volmax and the noise margin for an output high is equal to Vohmin - Vihmin","Noise margin");

        }

        private void StaticPower_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Static power without I/O transition, When the rise and fall times of the input pulse is sufficiently large the pMOS and nMOS can be ON simulataneously hence causing a static or short ckt power dissipation, becuase a direct short ckt path is formed between VDD and gnd. For small load capacitances the static power dissipation is predominant ", " Static (short ckt) Power Dissipation");
        }

        private void DynamicPower_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dynamic power dissipation occurs when the load capacitor is charging/discharing. It is independent of the rise and fall times of the input pulse and when the load capacitance is large the dynamic power dissipation dominates the static power dissipation ", " Dynamic Power Dissipation");
        }

        private void LeakagePowerDissipation_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Leakage power dissipation is due to the subthreshold current and the leakage current through the pMOS and nMOS transistors, when Vgs<Vt, the pMOS and nMOS transistors can have a subthreshold current. Another leakage component is the reverse diode leakage current, for ex when the pMOS Xsistor is OFF, a reverse saturation current flows through the drain-bulk junction of the pMOS Xsistor ", " Leakage Power Dissipation");

        }

        private void PowerReductionTechniques_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" The dynamic power dissipation can be reduced with a lower voltage power supply,  however since the the prop delay is inversely proporational to the Vdd, there is a negative impact on the delay of the inverter. Alternatives include reduction of load capacitance value, reduce the length of the interconnect at the output, reduce the Xsistor count and circuit nodes, reduce the Xsistor size. Static power can be reduced by lowering the clock frequency and having fast rise/fall times  ", " Power Reduction Techniques");
        }

        private void DesignForTestability_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" Extra circuitry in the chip is introduced for DFT and this reduces the cost of manufacturing and testing. Built in self test, scan test and boundary scan test fall in the category of DFT", "Design for Testability");

        }

        private void TreeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void analogCTLE_Click(object sender, EventArgs e)
        {
         MessageBox.Show("Continuous-time linear equalizers are analog in nature. A passive CTLE does not amplify any of the components instead it attenuates the low frequency signal components to achieve the high pass effect. Main components of a passive CTLE equal the termination and highpass filter.Active CTLE are implemented with active components such as amplifiers to provide the required signal gain", "Analog CTLE");
        }

        private void DiscreteLinear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The architecture consists of the transversal filter also known as the finite impulse response(FIR) filter. The Precursor taps have negative coefficients that compensate for phase distortion induced by dispersion it requires only a single tap.Postcursor tap have positive coefficient that compensate for ISI caused by amplitude distortion and may require multiple taps", "Discrete Linear Equalizers");
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ChannelSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The differential transmitter with 6db de-emphasis does include minimal jitter parameters. The bit rate is 5Gbps with an amplitude of +/-0.8v. The transmission path is a tightly coupled differential trace, the substrate has a dielectric value of 3.4 and a ground reference on either side with a 9 mil height. The length of the transmission path is 1.6inch at the receiver end and equalization is enabled.  Jitter is not included on the receiver side.  Adding a 2pF capacitance on either side of the transmitter and receiver would display a realistic parasitic capacitance on the channel link ", "Channel Simulation");

        }

        private void InsertionBudget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Further simulations include 3D FEM simulations in Ansys HFSS to further create an insertion loss budget for a differential transmission path through differential vias. The goal is to build an insertion loss budget for the differential traces. The insertion loss budget will take into account the via inductance, the loss tangent of the dielectric, the via inductance due to the via length, the length of the differential traces and the wave ports", "Insertion Loss Budget");

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
