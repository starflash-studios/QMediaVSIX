﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePicker))]
  [Guid(4201766833, 9022, 20273, 184, 190, 166, 234, 103, 12, 37, 205)]
  internal interface ITimePickerStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty ClockIdentifierProperty { get; }

    DependencyProperty MinuteIncrementProperty { get; }

    DependencyProperty TimeProperty { get; }
  }
}