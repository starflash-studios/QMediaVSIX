// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeneralTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GeneralTransform))]
  [Guid(2691143863, 41708, 16735, 173, 226, 234, 222, 147, 51, 242, 199)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeneralTransform
  {
    GeneralTransform Inverse { get; }

    Point TransformPoint(Point point);

    bool TryTransform(Point inPoint, out Point outPoint);

    Rect TransformBounds(Rect rect);
  }
}
