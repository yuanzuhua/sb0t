﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using iconnect;

namespace testext
{
    class MyPlugin : IExtension
    {
        public void ServerStarted() { }

        public void CycleTick() { }

        public void UnhandledProtocol(IUser client, bool custom, byte msg, byte[] packet) { }

        public bool Joining(IUser client) { return true; }

        public void Joined(IUser client) { }

        public void Rejected(IUser client, RejectedMsg msg) { client.Print("test"); }

        public void Parting(IUser client) { }

        public void Parted(IUser client) { }

        public bool AvatarReceived(IUser client) { return true; }

        public bool PersonalMessageReceived(IUser client, String text) { return true; }

        public void TextReceived(IUser client, String text) { }

        public String TextSending(IUser client, String text) { return text; }

        public void TextSent(IUser client, String text) { }

        public void EmoteReceived(IUser client, String text) { }

        public String EmoteSending(IUser client, String text) { return text; }

        public void EmoteSent(IUser client, String text) { }

        public void PrivateSending(IUser client, IUser target, IPrivateMsg msg) { }

        public void PrivateSent(IUser client, IUser target) { }

        public void BotPrivateSent(IUser client, String text) { }

        public bool Nick(IUser client, String name) { return true; }

        public void Help(IUser client) { }

        public void FileReceived(IUser client, String filename, String title, MimeType type) { }

        public bool Ignoring(IUser client, IUser target) { return true; }

        public void IgnoredStateChanged(IUser client, IUser target, bool ignored) { }

        public void InvalidLoginAttempt(IUser client) { }

        public void LoginGranted(IUser client) { }

        public void AdminLevelChanged(IUser client) { }

        public bool Registering(IUser client) { return true; }

        public void Registered(IUser client) { }

        public void Unregistered(IUser client) { }

        public void CaptchaSending(IUser client) { }

        public void CaptchaReply(IUser client, String reply) { }

        public bool VroomChanging(IUser client, ushort vroom) { return true; }

        public void VroomChanged(IUser client) { }

        public bool Flooding(IUser client, byte msg) { return true; }

        public void Flooded(IUser client) { }

        public bool ProxyDetected(IUser client) { return true; }

        public void Logout(IUser client) { }

        public void Idled(IUser client) { }

        public void Unidled(IUser client, uint seconds_away) { }

        public void BansAutoCleared() { }

        public void Command(IUser client, String cmd, IUser target, String args) { }

        public void Load() { }

        public void Dispose() { }

        public MyPlugin(IHostApp cb)
        {
            Server.SetCallback(cb);
            this.GUI = new MyGUI();
        }

        public BitmapSource Icon
        {
            get { return new BitmapImage(new Uri("pack://application:,,/testext;Component/Images/aliceS.png")); }
        }

        public UserControl GUI { get; private set; }
    }
}