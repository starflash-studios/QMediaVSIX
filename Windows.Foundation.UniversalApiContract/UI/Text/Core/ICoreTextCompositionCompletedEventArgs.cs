// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(523561910, 47007, 16673, 165, 231, 253, 169, 184, 97, 110, 48)]
  [ExclusiveTo(typeof (CoreTextCompositionCompletedEventArgs))]
  internal interface ICoreTextCompositionCompletedEventArgs
  {
    bool IsCanceled { get; }

    IVectorView<CoreTextCompositionSegment> CompositionSegments { get; }

    Deferral GetDeferral();
  }
}
