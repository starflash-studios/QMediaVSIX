// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IPointer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Pointer))]
  [WebHostHidden]
  [Guid(1592325023, 29821, 16753, 144, 230, 205, 55, 169, 223, 251, 17)]
  internal interface IPointer
  {
    uint PointerId { get; }

    PointerDeviceType PointerDeviceType { get; }

    bool IsInContact { get; }

    bool IsInRange { get; }
  }
}
