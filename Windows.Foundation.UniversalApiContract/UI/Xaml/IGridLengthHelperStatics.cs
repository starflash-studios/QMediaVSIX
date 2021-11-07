// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IGridLengthHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (GridLengthHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2638576539, 415, 16998, 136, 114, 33, 95, 25, 143, 106, 157)]
  internal interface IGridLengthHelperStatics
  {
    GridLength Auto { get; }

    GridLength FromPixels(double pixels);

    GridLength FromValueAndType(double value, GridUnitType type);

    bool GetIsAbsolute(GridLength target);

    bool GetIsAuto(GridLength target);

    bool GetIsStar(GridLength target);

    bool Equals(GridLength target, GridLength value);
  }
}
