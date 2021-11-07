// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkInputProcessingConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(662231134, 13258, 19206, 166, 211, 172, 57, 69, 17, 109, 55)]
  [ExclusiveTo(typeof (InkInputProcessingConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkInputProcessingConfiguration
  {
    InkInputProcessingMode Mode { get; set; }

    InkInputRightDragAction RightDragAction { get; set; }
  }
}
