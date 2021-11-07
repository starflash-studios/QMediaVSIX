// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IGettingFocusEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (GettingFocusEventArgs))]
  [Guid(1308772497, 56127, 24184, 183, 90, 98, 191, 195, 81, 7, 53)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IGettingFocusEventArgs3
  {
    Guid CorrelationId { get; }
  }
}
