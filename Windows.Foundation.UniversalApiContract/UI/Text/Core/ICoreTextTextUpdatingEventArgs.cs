// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  [Guid(4003959181, 52267, 20227, 143, 246, 2, 253, 33, 125, 180, 80)]
  [ExclusiveTo(typeof (CoreTextTextUpdatingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextTextUpdatingEventArgs
  {
    CoreTextRange Range { get; }

    string Text { get; }

    CoreTextRange NewSelection { get; }

    Language InputLanguage { get; }

    CoreTextTextUpdatingResult Result { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
