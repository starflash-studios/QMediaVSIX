// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.RatedContentCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  /// <summary>Specifies the type of a piece of content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RatedContentCategory
  {
    /// <summary>In-app content for Windows 8.1 and Xbox apps.</summary>
    General,
    /// <summary>Apps on Windows 8.1 and Xbox.</summary>
    Application,
    /// <summary>Apps on Windows 8.1 and Xbox.</summary>
    Game,
    /// <summary>In-app content for Windows 8.1 and Xbox apps.</summary>
    Movie,
    /// <summary>In-app content for Windows 8.1 and Xbox apps.</summary>
    Television,
    /// <summary>In-app content for Windows 8.1 and Xbox apps.</summary>
    Music,
  }
}
