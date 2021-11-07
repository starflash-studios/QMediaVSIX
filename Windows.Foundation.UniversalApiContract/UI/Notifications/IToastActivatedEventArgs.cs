// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastActivatedEventArgs))]
  [Guid(3820983027, 49559, 17263, 130, 101, 6, 37, 130, 79, 141, 172)]
  internal interface IToastActivatedEventArgs
  {
    string Arguments { get; }
  }
}
