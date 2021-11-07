// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ISystemFunctionLockChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [WebHostHidden]
  [Guid(3439592968, 64761, 22620, 190, 171, 241, 210, 234, 243, 100, 171)]
  [ExclusiveTo(typeof (SystemFunctionLockChangedEventArgs))]
  internal interface ISystemFunctionLockChangedEventArgs
  {
    ulong Timestamp { get; }

    bool IsLocked { get; }

    bool Handled { get; set; }
  }
}
