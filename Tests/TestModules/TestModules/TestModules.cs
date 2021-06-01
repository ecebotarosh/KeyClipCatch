using NUnit.Framework;
using System;

namespace TestModules
{
    public class Tests
    {
        private Modules.GetClipboardTextModule textGetter = null;
        private Modules.GetClipboardImageModule imageGetter = null;
        private Modules.SetClipboardTextModule textSetter = null;
        private Keylogger.Keylogger keylogger = null;

        [SetUp]
        [STAThread]
        public void SetUp()
        {
            textGetter = new Modules.GetClipboardTextModule();
            imageGetter = new Modules.GetClipboardImageModule();
            textSetter = new Modules.SetClipboardTextModule();
            keylogger = new Keylogger.Keylogger();
        }

        [Test]
        [STAThread]
        public void TestBasicClipboardSet1()
        {
            textSetter.Execute("\"bona sera\"");
            textGetter.Execute();
            Assert.AreEqual(System.Text.Encoding.UTF8.GetString(textGetter.GetData().Data), "\"bona sera\"");
        }

        [Test]
        [STAThread]
        public void TestBasicClipboardSet2()
        {
            textSetter.Execute("Buna seara, boieri mari!");
            textGetter.Execute();
            Assert.AreEqual(System.Text.Encoding.UTF8.GetString(textGetter.GetData().Data), "Buna seara, boieri mari!");
        }

        [Test]
        [STAThread]
        //https://stackoverflow.com/questions/17753447/automated-prtscn-keystroke-acts-like-altprtscrn
        public void TestGetClipboardTextIfAlreadyImage()
        {
            System.Windows.Forms.SendKeys.SendWait("{PRTSC}");
            Assert.Throws<Exception>(() => textGetter.Execute());
        }

        [Test]
        public void TestGetClipboardImageIfAlreadyText()
        {
            textSetter.Execute("asd");
            Assert.Throws<Exception>(() => imageGetter.Execute());
        }

        [Test]
        public void TestKeylogger()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("asd");
            keylogger.Stop();
            Assert.AreEqual(keylogger.GetLoggedData(), "ASD");
        }

        [Test]
        public void TestKeylogger1()
        {
            keylogger.Start();
            keylogger.Stop();
            Assert.AreEqual(keylogger.GetLoggedData(), "");
        }

        [Test]
        public void TestKeylogger2()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{BS}");
            keylogger.Stop();
            Assert.AreEqual(keylogger.GetLoggedData(), "<Backspace>");
        }

        [Test]
        public void TestKeylogger3()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("Hello {BS}Friends");
            keylogger.Stop();
            Assert.AreEqual("<Shift>HELLO <Backspace><Shift>FRIENDS", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger4()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{NUMLOCK}");
            keylogger.Stop();
            Assert.AreEqual("<NumLock><NumLock>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger5()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{ADD}");
            keylogger.Stop();
            Assert.AreEqual("<Numpad+>", keylogger.GetLoggedData());
        }
        
        [Test]
        public void TestKeylogger6()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{SUBTRACT}");
            keylogger.Stop();
            Assert.AreEqual("<Numpad->", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger7()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{MULTIPLY}");
            keylogger.Stop();
            Assert.AreEqual("<Numpad*>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger8()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{DIVIDE}");
            keylogger.Stop();
            Assert.AreEqual("<Numpad/>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger9()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{F1}{F12}");
            keylogger.Stop();
            Assert.AreEqual("<F1><F12>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger10()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("!");
            keylogger.Stop();
            Assert.AreEqual("<Shift>1", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger11()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("emil.cebotarosh@student.tuiasi.ro");
            keylogger.Stop();
            Assert.AreEqual("EMIL\u00BECEBOTAROSH<Shift>2STUDENT\u00BETUIASI\u00BERO", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger12()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("Parola!Super!Secreta159!@#");
            keylogger.Stop();
            Assert.AreEqual("<Shift>PAROLA<Shift>1<Shift>SUPER<Shift>1<Shift>SECRETA159<Shift>1<Shift>2<Shift>3", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger13()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{DOWN}");
            keylogger.Stop();
            Assert.AreEqual("<ArrowDown>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger14()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{UP}{DOWN}{LEFT}{RIGHT}");
            keylogger.Stop();
            Assert.AreEqual("<ArrowUp><ArrowDown><ArrowLeft><ArrowRight>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger15()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{CAPSLOCK}");
            keylogger.Stop();
            Assert.AreEqual("<Caps><Caps>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger16()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{ESC}");
            keylogger.Stop();
            Assert.AreEqual("<Escape>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger17()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{SCROLLLOCK}");
            keylogger.Stop();
            Assert.AreEqual("<ScrollLock><ScrollLock>", keylogger.GetLoggedData());
        }

        [Test]
        public void TestKeylogger18()
        {
            keylogger.Start();
            System.Windows.Forms.SendKeys.SendWait("{HOME}");
            keylogger.Stop();
            Assert.AreEqual("<Home>", keylogger.GetLoggedData());
        }
    }
}