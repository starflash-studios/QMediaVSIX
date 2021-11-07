// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerGotFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FocusManagerGotFocusEventArgs))]
  [Guid(2544524675, 21339, 20602, 134, 142, 98, 183, 6, 240, 107, 97)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IFocusManagerGotFocusEventArgs
  {
    DependencyObject NewFocusedElement { get; }

    Guid CorrelationId { get; }
  }
}
