﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGeneratorPositionHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(2906691021, 24812, 17800, 141, 96, 57, 210, 144, 151, 164, 223)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GeneratorPositionHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeneratorPositionHelperStatics
  {
    GeneratorPosition FromIndexAndOffset(int index, int offset);
  }
}