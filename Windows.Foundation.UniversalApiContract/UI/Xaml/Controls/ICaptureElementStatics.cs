// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICaptureElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(507743725, 32166, 16542, 128, 110, 48, 90, 228, 173, 155, 63)]
  [ExclusiveTo(typeof (CaptureElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICaptureElementStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
