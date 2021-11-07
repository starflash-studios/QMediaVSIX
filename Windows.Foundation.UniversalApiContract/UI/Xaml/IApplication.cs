// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1958240673, 29831, 18089, 154, 110, 199, 139, 81, 39, 38, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Application))]
  [WebHostHidden]
  internal interface IApplication
  {
    ResourceDictionary Resources { get; set; }

    DebugSettings DebugSettings { get; }

    ApplicationTheme RequestedTheme { get; set; }

    event UnhandledExceptionEventHandler UnhandledException;

    event SuspendingEventHandler Suspending;

    event EventHandler<object> Resuming;

    void Exit();
  }
}
