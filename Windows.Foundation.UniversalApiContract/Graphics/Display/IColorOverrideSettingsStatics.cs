﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IColorOverrideSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(2959663199, 50207, 19145, 175, 171, 130, 122, 182, 36, 143, 154)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (ColorOverrideSettings))]
  internal interface IColorOverrideSettingsStatics
  {
    ColorOverrideSettings CreateFromDisplayColorOverrideScenario(
      DisplayColorOverrideScenario overrideScenario);
  }
}