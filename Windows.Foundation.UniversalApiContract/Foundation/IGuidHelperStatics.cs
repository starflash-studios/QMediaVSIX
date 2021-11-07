// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IGuidHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1506252395, 44626, 21123, 173, 127, 161, 185, 233, 103, 138, 221)]
  [ExclusiveTo(typeof (GuidHelper))]
  internal interface IGuidHelperStatics
  {
    Guid CreateNewGuid();

    Guid Empty { get; }

    bool Equals(ref Guid target, ref Guid value);
  }
}
