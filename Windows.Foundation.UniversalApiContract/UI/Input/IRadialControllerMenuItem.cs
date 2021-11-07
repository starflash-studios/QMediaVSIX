// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  [Guid(3356477837, 44299, 19612, 143, 47, 19, 106, 35, 115, 166, 186)]
  internal interface IRadialControllerMenuItem
  {
    string DisplayText { get; }

    object Tag { [return: Variant] get; [param: Variant] set; }

    event TypedEventHandler<RadialControllerMenuItem, object> Invoked;
  }
}
