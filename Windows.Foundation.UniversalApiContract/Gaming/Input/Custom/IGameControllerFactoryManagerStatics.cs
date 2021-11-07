// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerFactoryManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ExclusiveTo(typeof (GameControllerFactoryManager))]
  [WebHostHidden]
  [Guid(919299811, 53409, 18822, 162, 76, 64, 177, 55, 222, 186, 158)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IGameControllerFactoryManagerStatics
  {
    void RegisterCustomFactoryForGipInterface(
      ICustomGameControllerFactory factory,
      Guid interfaceId);

    void RegisterCustomFactoryForHardwareId(
      ICustomGameControllerFactory factory,
      ushort hardwareVendorId,
      ushort hardwareProductId);

    void RegisterCustomFactoryForXusbType(
      ICustomGameControllerFactory factory,
      XusbDeviceType xusbType,
      XusbDeviceSubtype xusbSubtype);
  }
}
