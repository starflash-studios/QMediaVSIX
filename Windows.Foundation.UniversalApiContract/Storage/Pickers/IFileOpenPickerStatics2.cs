﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPickerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileOpenPicker))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3901846549, 60893, 23704, 182, 243, 54, 111, 223, 202, 211, 146)]
  internal interface IFileOpenPickerStatics2
  {
    FileOpenPicker CreateForUser(User user);
  }
}