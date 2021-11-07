// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextCompositionSegment))]
  [Guid(2003594201, 20141, 19879, 143, 71, 58, 136, 181, 35, 204, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextCompositionSegment
  {
    string PreconversionString { get; }

    CoreTextRange Range { get; }
  }
}
