// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (LauncherOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3136954840, 45169, 19672, 133, 62, 52, 18, 3, 229, 87, 211)]
  internal interface ILauncherOptions
  {
    bool TreatAsUntrusted { get; set; }

    bool DisplayApplicationPicker { get; set; }

    LauncherUIOptions UI { get; }

    string PreferredApplicationPackageFamilyName { get; set; }

    string PreferredApplicationDisplayName { get; set; }

    Uri FallbackUri { get; set; }

    string ContentType { get; set; }
  }
}
