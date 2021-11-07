// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPointHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PointHelper))]
  [Guid(22727285, 30424, 19326, 138, 51, 125, 121, 32, 70, 145, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointHelperStatics
  {
    Point FromCoordinates(float x, float y);
  }
}
