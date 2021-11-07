// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.ContentAccessRestrictionLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  /// <summary>Specifies how the content is treated, based on the user's content settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContentAccessRestrictionLevel
  {
    /// <summary>Can be shown in the content catalog and consumed.</summary>
    Allow,
    /// <summary>(Xbox only) If multiple users are logged in and the content is blocked for at least one user, content is allowed with a warning displayed.</summary>
    Warn,
    /// <summary>Can be shown in the content catalog, but will be blocked by RequestContentAccessAsync.</summary>
    Block,
    /// <summary>Can't be shown in the content catalog. It's rating is higher than the user's settings, determined by MaxBrowsableAgeRating.</summary>
    Hide,
  }
}
