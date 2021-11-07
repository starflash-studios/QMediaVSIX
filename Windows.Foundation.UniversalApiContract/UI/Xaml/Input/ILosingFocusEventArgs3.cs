// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ILosingFocusEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LosingFocusEventArgs))]
  [Guid(3381199037, 2937, 22126, 173, 31, 67, 111, 165, 19, 174, 34)]
  [WebHostHidden]
  internal interface ILosingFocusEventArgs3
  {
    Guid CorrelationId { get; }
  }
}
