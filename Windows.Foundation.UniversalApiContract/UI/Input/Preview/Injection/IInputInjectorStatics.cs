﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjectorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(3735972163, 29698, 16705, 165, 198, 12, 1, 170, 87, 177, 106)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InputInjector))]
  internal interface IInputInjectorStatics
  {
    InputInjector TryCreate();
  }
}