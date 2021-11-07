// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ISystemFunctionLockIndicatorChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (SystemFunctionLockIndicatorChangedEventArgs))]
  [Guid(2987571534, 31343, 22702, 179, 4, 186, 230, 29, 3, 113, 185)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ISystemFunctionLockIndicatorChangedEventArgs
  {
    ulong Timestamp { get; }

    bool IsIndicatorOn { get; }

    bool Handled { get; set; }
  }
}
