// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ISystemFunctionButtonEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SystemFunctionButtonEventArgs))]
  [Guid(1211337071, 32977, 24022, 146, 167, 98, 165, 8, 255, 239, 90)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ISystemFunctionButtonEventArgs
  {
    ulong Timestamp { get; }

    bool Handled { get; set; }
  }
}
