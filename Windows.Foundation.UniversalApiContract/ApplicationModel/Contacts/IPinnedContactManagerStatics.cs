﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4133276798, 65017, 18538, 172, 233, 188, 49, 29, 10, 231, 240)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PinnedContactManager))]
  internal interface IPinnedContactManagerStatics
  {
    PinnedContactManager GetDefault();

    PinnedContactManager GetForUser(User user);

    bool IsSupported();
  }
}