﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IResourceDictionary
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3253358372, 55006, 16785, 142, 58, 244, 134, 1, 247, 72, 156)]
  [ExclusiveTo(typeof (ResourceDictionary))]
  internal interface IResourceDictionary
  {
    Uri Source { get; set; }

    IVector<ResourceDictionary> MergedDictionaries { get; }

    IMap<object, object> ThemeDictionaries { get; }
  }
}