﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.CardAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Provides data for the CardAdded event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CardAddedEventArgs : ICardAddedEventArgs
  {
    /// <summary>Gets info about the smart card that was inserted into the smart card reader.</summary>
    /// <returns>Info about the smart card that was inserted.</returns>
    public extern SmartCard SmartCard { [MethodImpl] get; }
  }
}