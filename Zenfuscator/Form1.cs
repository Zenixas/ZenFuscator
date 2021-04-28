using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Zenfuscator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string[] attrib = {  "ObfuscatedByGoliath", "NineRays.Obfuscator.Evaluation", "NetGuard", "dotNetProtector", "YanoAttribute", "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode", "PoweredByAttribute", "DotNetPatcherPackerAttribute", "DotNetPatcherObfuscatorAttribute", "DotfuscatorAttribute", "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute", "BabelObfuscatorAttribute", "BabelAttribute", "AssemblyInfoAttribute", "ZYXDNGuarder", "ConfusedByAttribute"};
        bool protectname = false;
        bool fakeobf = false;
        bool junkatrb = false;
        bool encryptstring = false;
        bool antide4dot = false;

        public Form1()
        {
            InitializeComponent();
        }
        public static byte[] encodeBytes(byte[] bytes, string pass)
        {
            byte[] ZenBytes = Encoding.Unicode.GetBytes(pass);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= ZenBytes[i % 16];
            }
            return bytes;
        }

        public static byte[] decryptBytes(byte[] bytes, String pass)
        {
            byte[] ZenBytes = Encoding.Unicode.GetBytes(pass);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= ZenBytes[i % 16];
            }
            return bytes;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void ProtectName(AssemblyDef assembly, ModuleDef mod)
        {

            foreach (TypeDef type in mod.Types)
            {
                mod.Name = "ObfuscatedByProjectZen";
                if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                {
                    continue;
                }
                else
                {
                    foreach (PropertyDef property in type.Properties)
                    {
                        if (property.IsRuntimeSpecialName) continue;
                        property.Name = RandomString(20) + "難読化ＰＲＯＪＥＣＴ-ＺＥＮ難読化";
                    }
                    foreach (FieldDef fields in type.Fields)
                    {
                        fields.Name = RandomString(20) + "難読化ＰＲＯＪＥＣＴ-ＺＥＮ難読化";
                    }
                    foreach (EventDef eventdef in type.Events)
                    {
                        eventdef.Name = RandomString(20) + "難読化ＰＲＯＪＥＣＴ-ＺＥＮ難読化";
                    }
                    foreach (MethodDef method in type.Methods)
                    {
                        if (method.IsConstructor || method.IsRuntimeSpecialName || method.IsRuntime || method.IsStaticConstructor || method.IsVirtual) continue;
                        method.Name = RandomString(20);
                    }
                }
            }
        }

        public void fakeobfuscation(ModuleDefMD module)
        {
            for (int i = 0; i < attrib.Length; i++)
            {
                var fakeattrib = new TypeDefUser(attrib[i], attrib[i], module.CorLibTypes.Object.TypeDefOrRef);
                fakeattrib.Attributes = TypeAttributes.Class | TypeAttributes.NotPublic | TypeAttributes.WindowsRuntime;
                module.Types.Add(fakeattrib);
            }
        }

        public void junkattrib(ModuleDefMD module)
        {
            int number = System.Convert.ToInt32(metroTextBox2.Text);
            for (int i = 0; i < number; i++)
            {
                var junkatrb = new TypeDefUser("難読化ＰＲＯＪＥＣＴ-ＺＥＮ難読化" + RandomString(20), "難読化ＰＲＯＪＥＣＴ-ＺＥＮ難読化" + RandomString(20), module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(junkatrb);
            }
        }

        public void encryptString(ModuleDef module)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (method.Body == null) continue;
                    method.Body.SimplifyBranches();
                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            string base64toencrypt = method.Body.Instructions[i].Operand.ToString();
                            string base64EncryptedString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(base64toencrypt));
                            method.Body.Instructions[i].OpCode = OpCodes.Nop;
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, module.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8", new Type[] { }))));
                            method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, base64EncryptedString));
                            method.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, module.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) }))));
                            method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, module.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
                            i += 4;
                        }
                    }
                }
            }
        }

        public void antiDe4Dot(ModuleDefMD module)
        {
            Random rnd = new Random();
            InterfaceImpl Interface = new InterfaceImplUser(module.GlobalType);
            for (int i = 200; i < 300; i++)
            {
                TypeDef typedef = new TypeDefUser("", $"Form{i.ToString()}", module.CorLibTypes.GetTypeRef("System", "Attribute"));
                InterfaceImpl interface1 = new InterfaceImplUser(typedef);
                module.Types.Add(typedef);
                typedef.Interfaces.Add(interface1);
                typedef.Interfaces.Add(Interface);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Executables | *.*";
            openfiledialog.ShowDialog();
            metroTextBox1.Text = openfiledialog.FileName;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {}

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            protectname = !protectname;
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            fakeobf = !fakeobf;
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            junkatrb = !junkatrb;
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            antide4dot = !antide4dot;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            encryptstring = !encryptstring;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {}

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AssemblyDef assembly = AssemblyDef.Load(metroTextBox1.Text);
            ModuleContext modCtx = ModuleDefMD.CreateModuleContext();
            ModuleDefMD module = ModuleDefMD.Load(metroTextBox1.Text, modCtx);
            if (antide4dot == true)
            {
                antiDe4Dot(module);
                module.Write(metroTextBox3.Text + ".exe");
            }
            if (protectname == true)
            {
                ProtectName(assembly, module);
                module.Write(metroTextBox3.Text + ".exe");
            }
            if (fakeobf == true)
            {
                fakeobfuscation(module);
                module.Write(metroTextBox3.Text + ".exe");
            }
            if (junkatrb == true)
            {
                junkattrib(module);
                module.Write(metroTextBox3.Text + ".exe");
            }
            if (encryptstring == true)
            {
                encryptString(module);
                module.Write(metroTextBox3.Text + ".exe");
            }
            MessageBox.Show("Thank you for using the obfuscator :)", "Thank you for using the obfuscator :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {}
    }
}
