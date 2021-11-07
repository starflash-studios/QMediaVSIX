// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextTextRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1356419241, 62750, 19649, 140, 161, 230, 52, 109, 26, 97, 190)]
  internal interface ICoreTextTextRequest
  {
    CoreTextRange Range { get; }

    string Text { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
