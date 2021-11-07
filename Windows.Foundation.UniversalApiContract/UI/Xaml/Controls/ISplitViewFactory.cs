// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4043405114, 2126, 20409, 132, 66, 99, 34, 27, 68, 83, 63)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplitView))]
  internal interface ISplitViewFactory
  {
    SplitView CreateInstance(object baseInterface, out object innerInterface);
  }
}
