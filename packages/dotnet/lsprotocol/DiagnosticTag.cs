// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// 
// THIS FILE IS AUTOGENERATED, DO NOT MODIFY IT

namespace LSProtocol {
    /// <summary>
    /// The diagnostic tags.
    /// 
    /// @since 3.15.0
    /// </summary>
    public enum DiagnosticTag 
    {
        /// <summary>
        /// Unused or unnecessary code.
        /// 
        /// Clients are allowed to render diagnostics with this tag faded out instead of having
        /// an error squiggle.
        /// </summary>
        Unnecessary = 1,

        /// <summary>
        /// Deprecated or obsolete code.
        /// 
        /// Clients are allowed to rendered diagnostics with this tag strike through.
        /// </summary>
        Deprecated = 2,

    }
}
