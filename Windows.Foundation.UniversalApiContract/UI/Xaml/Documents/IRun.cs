// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IRun
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Run))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1498758275, 3604, 18877, 184, 75, 197, 38, 243, 3, 67, 73)]
  internal interface IRun
  {
    string Text { get; set; }

    FlowDirection FlowDirection { get; set; }
  }
}
