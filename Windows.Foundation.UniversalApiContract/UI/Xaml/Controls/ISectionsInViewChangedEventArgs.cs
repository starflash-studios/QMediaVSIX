// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISectionsInViewChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SectionsInViewChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3712609899, 53605, 17167, 163, 125, 184, 7, 6, 79, 133, 225)]
  internal interface ISectionsInViewChangedEventArgs
  {
    IVector<HubSection> AddedSections { get; }

    IVector<HubSection> RemovedSections { get; }
  }
}
