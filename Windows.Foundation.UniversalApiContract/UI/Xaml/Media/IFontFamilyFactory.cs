﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IFontFamilyFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3579851639, 15790, 19917, 175, 9, 249, 73, 142, 158, 198, 89)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FontFamily))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontFamilyFactory
  {
    FontFamily CreateInstanceWithName(
      string familyName,
      object baseInterface,
      out object innerInterface);
  }
}