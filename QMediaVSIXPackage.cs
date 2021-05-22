#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using QMediaVSIX.Commands;
using Task = System.Threading.Tasks.Task;

#endregion

namespace QMediaVSIX {
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)][Guid(PackageGuidString)][ProvideMenuResource("Menus.ctmenu", 1)][ProvideOptionPage(typeof(OptionPageGrid_English), "QMediaVSIX", "English", 0, 0, true)][ProvideOptionPage(typeof(OptionPageGrid_Japanese), "QMediaVSIX", "日本語", 0, 0, true)]
    public sealed class QMediaVSIXPackage : AsyncPackage {
        /// <summary>
        /// QMediaVSIXPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "1ddfb4c3-5267-4a30-927d-62e83facb999";

        public static QMediaVSIXPackage Instance;

        //[Import] internal SVsServiceProvider ServiceProvider = null;

        #region Package Members

        /// <summary>
        /// Initialisation of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialisation code that rely on services provided by VisualStudio.
        /// </summary>
        /// <param name="CT">A cancellation token to monitor for initialisation cancellation, which can occur when VS is shutting down.</param>
        /// <param name="Progress">A provider for progress updates.</param>
        /// <returns>A task representing the async work of package initialisation, or an already completed task if there is none. Do not return null from this method.</returns>
        protected override async Task InitializeAsync(CancellationToken CT, IProgress<ServiceProgressData> Progress) {
            Instance = this;
            // When initialised asynchronously, the current thread may be a background thread at this point.
            // Do any initialisation that requires the UI thread after switching to the UI thread.
            await JoinableTaskFactory.SwitchToMainThreadAsync(CT);

            await CommandsGlobal.PrepareAsync(); //Prepare media-detection utilities

            await CommandsPlayPause.InitializeAsync(this);
            await CommandsMediaInfo.InitializeAsync(this);
            await CommandsSkipFwd.InitializeAsync(this);
            await CommandsSkipRev.InitializeAsync(this);
            await CommandsShuffle.InitializeAsync(this);
            await CommandsRepeat.InitializeAsync(this);

            //_ = new ResMan();
            //Assembly Ass = Assembly.GetExecutingAssembly();
            //foreach(string ResName in Ass.GetManifestResourceNames()) {
            //    Debug.WriteLine($"Retrieved manifest resource name {ResName}");
            //}
            //Debug.WriteLine($"All manifest resources were retrieved.");
            //ResourceManager RM = new ResourceManager("RMC", typeof(QMediaVSIXPackage).Assembly);

            //ResourceManager RM = ResourceManager.CreateFileBasedResourceManager("Strings", "i18n", null);
            //Debug.WriteLine($"From '{RM}' retrieved 'TestString': '{RM.GetString("TestString")}'");
        }

        ~QMediaVSIXPackage() {
            CommandsGlobal.Destruct();
        }

        #endregion

        public int FallbackDelay => OptionPageGrid_i18n.Int_FallbackDelay;
    }

    // ReSharper disable once InconsistentNaming
    public abstract class OptionPageGrid_i18n : DialogPage {
        internal static int Int_FallbackDelay = 2000;

        public abstract int FallbackDelay { get; set; }

        public static T Get<T>() where T : OptionPageGrid_i18n => QMediaVSIXPackage.Instance.GetDialogPage(typeof(T)) as T;
    }

    public class OptionPageGrid_English : OptionPageGrid_i18n {
        [Category("English")][DisplayName("Fallback Delay")][Description("The delay before the extension falls back to media keys.\nIf controlling a media source fails, the extension waits for some time to ensure it wasn't just lagging, and then manually invokes keyboard media keys (which may control the wrong media source by accident.)\n\nSet to '0' to use exclusively media keys, and any negative values to disable the fallback entirely.")]
        public override int FallbackDelay {
            get => Int_FallbackDelay;
            set => Int_FallbackDelay = value;
        }
    }

    public class OptionPageGrid_Japanese : OptionPageGrid_i18n {
        [Category("日本語")][DisplayName("フォールバック遅延")][Description(">この設定は拡張機能がメディアキーにフォールバックするまでの遅延時間です。\nボタンコマンドが失敗した場合、エクステンションは遅延していないことを確認するためにしばらく待ちます。遅延後、メディアからの応答がない場合、拡張機能は手動でキーボードキーを押します。\nこれは、誤ったメディアソースを制御する可能性があるため、通常は避けます。\n\nキーボードキーのみを使用する場合は「0」に設定します。\nまた、負の値を設定すると、フォールバックを完全に無効にすることができます。")]
        public override int FallbackDelay {
            get => Int_FallbackDelay;
            set => Int_FallbackDelay = value;
        }
    }
}
