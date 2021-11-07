// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkInputConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2477166020, 2939, 18903, 179, 79, 153, 1, 229, 36, 220, 242)]
  [ExclusiveTo(typeof (InkInputConfiguration))]
  internal interface IInkInputConfiguration
  {
    bool IsPrimaryBarrelButtonInputEnabled { get; set; }

    bool IsEraserInputEnabled { get; set; }
  }
}
