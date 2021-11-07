// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(661329577, 25831, 19120, 188, 75, 160, 45, 115, 131, 91, 251)]
  [ExclusiveTo(typeof (CoreTextCompositionStartedEventArgs))]
  internal interface ICoreTextCompositionStartedEventArgs
  {
    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
