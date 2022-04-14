using NAudio.Wave;
using NAudio.Lame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AudioConverter {

    enum AudioFileType { 
        MP3,
        WAV,
        UNSUPPORTED
    }

    public partial class Form1 : Form {

        AudioFileType sourceFileType;
        string sourceFileName;
        string outDir = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "output");

        

        List<string> datasource = new List<string>();
        

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            datasource.Add("MP3");
            datasource.Add("WAV");
            datasource.Add("UNSUPPORTED");

            combo_outFileType.DataSource = datasource.Take(datasource.Count - 1).ToArray();

            Console.WriteLine(Assembly.GetEntryAssembly().Location);
            Console.WriteLine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
        }

        private void ChooseFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Select Audio File";
            ofDialog.Filter = "audio files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
            ofDialog.RestoreDirectory = true;

            DialogResult result = ofDialog.ShowDialog();

            if (result == DialogResult.OK) {
                try {
                    //get source file
                    string fileName = ofDialog.FileName;
                    sourceFileName = fileName;
                    txt_inFile.Text = fileName;

                    //get source filetype
                    sourceFileType = GetAudioFileType(fileName.Split('.').Last());
                    int ftype = (int)sourceFileType;
                    string ftypeStr = datasource.ToArray()[ftype];
                    txt_inFileType.Text = ftypeStr;

                    //get all convertable type except the one chosen and unsupported
                    combo_outFileType.DataSource = datasource.Take(datasource.Count - 1).Where((v, i) => i != ftype).ToArray();

                } catch (Exception ex) {
                    txt_inFile.Text = "No File Selected";
                }   
            }
        }

        private AudioFileType GetAudioFileType(string extension) {
            switch (extension.ToUpper()) {
                case "MP3":
                    return AudioFileType.MP3;
                case "WAV":
                    return AudioFileType.WAV;
                default:
                    return AudioFileType.UNSUPPORTED;
            }
        }

        private void btn_convert_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(sourceFileName)) {

                lbl_warning.Text = "Source File needs to be selected before you can convert.";
                lbl_warning.ForeColor = Color.Red;
                return;
            }

            //check if directory exists
            if (!Directory.Exists(outDir)) {
                Directory.CreateDirectory(outDir);
            }
            //get source file name

            string outTypeText = combo_outFileType.SelectedItem.ToString();
            AudioFileType outType = GetAudioFileType(outTypeText);

            //convert based on file type
            if (sourceFileType == AudioFileType.MP3) {
                if (outType == AudioFileType.WAV) {
                    ConvertMp3toWav(sourceFileName);
                }
            }

            if (sourceFileType == AudioFileType.WAV) {
                if (outType == AudioFileType.MP3) {
                    ConvertWavtoMp3(sourceFileName);
                }
            }

            //save converted file to a specified folder
            //show link which will take you to the file

            //sourceFileName

            lbl_warning.Text = "";
            lbl_warning.ForeColor = Color.Black;
        }

        private void ConvertMp3toWav(string inPath) {
            try {
                using (Mp3FileReader mp3 = new Mp3FileReader(inPath)) {
                    using (WaveStream wavStream = WaveFormatConversionStream.CreatePcmStream(mp3)) {

                        //convert path
                        string fileName = Path.GetFileNameWithoutExtension(inPath);
                        string outPath = Path.Combine(outDir, fileName + ".wav");

                        WaveFileWriter.CreateWaveFile(outPath, wavStream);

                        lbl_warning.Text = "Processing...";
                        lbl_warning.ForeColor = Color.Black;

                    }
                }
            } catch (UnauthorizedAccessException ex) {
                lbl_warning.Text = "Output location requires elevated access.";
                lbl_warning.ForeColor = Color.Red;
                Console.WriteLine(ex.Message);

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } 
        }

        private void ConvertWavtoMp3(string inPath) {
            try {
                using (WaveFileReader wfr = new WaveFileReader(inPath)) {

                    string fileName = Path.GetFileNameWithoutExtension(inPath);
                    string outPath = Path.Combine(outDir, fileName + ".mp3");

                    LameMP3FileWriter lameMp3 = new LameMP3FileWriter(outPath, wfr.WaveFormat, 128);
                    wfr.CopyTo(lameMp3);

                    lbl_warning.Text = "Processing...";
                    lbl_warning.ForeColor = Color.Black;

                    lameMp3.Dispose();
                }
            } catch (UnauthorizedAccessException ex) {
                lbl_warning.Text = "Output location requires elevated access.";
                lbl_warning.ForeColor = Color.Red;
                Console.WriteLine(ex.Message);

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        //not used
        private void SetOutputFolder() { 

        }
    }
}
