﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerScreenContactContinuedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerScreenContactContinuedEventArgs))]
  [Guid(543859767, 58961, 4581, 191, 98, 44, 39, 215, 64, 78, 133)]
  internal interface IRadialControllerScreenContactContinuedEventArgs
  {
    RadialControllerScreenContact Contact { get; }
  }
}