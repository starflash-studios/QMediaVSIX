// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerLostFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1041596026, 38264, 23763, 170, 168, 5, 27, 61, 57, 25, 120)]
  [ExclusiveTo(typeof (FocusManagerLostFocusEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IFocusManagerLostFocusEventArgs
  {
    DependencyObject OldFocusedElement { get; }

    Guid CorrelationId { get; }
  }
}
