﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IKnownAdaptiveNotificationHintsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (KnownAdaptiveNotificationHints))]
  [Guid(102786456, 54422, 18813, 134, 146, 79, 125, 124, 39, 112, 223)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IKnownAdaptiveNotificationHintsStatics
  {
    string Style { get; }

    string Wrap { get; }

    string MaxLines { get; }

    string MinLines { get; }

    string TextStacking { get; }

    string Align { get; }
  }
}