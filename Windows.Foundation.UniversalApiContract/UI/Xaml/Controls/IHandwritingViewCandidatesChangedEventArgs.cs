﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingViewCandidatesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [Guid(1868522456, 22193, 22213, 164, 22, 193, 156, 22, 191, 120, 132)]
  [ExclusiveTo(typeof (HandwritingViewCandidatesChangedEventArgs))]
  internal interface IHandwritingViewCandidatesChangedEventArgs
  {
    uint CandidatesSessionId { get; }
  }
}