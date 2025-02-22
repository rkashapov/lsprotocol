// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// 
// THIS FILE IS AUTOGENERATED, DO NOT MODIFY IT

namespace LSProtocol {
    /// <summary>
    /// Defines whether the insert text in a completion item should be interpreted as
    /// plain text or a snippet.
    /// </summary>
    public enum InsertTextFormat 
    {
        /// <summary>
        /// The primary text to be inserted is treated as a plain string.
        /// </summary>
        PlainText = 1,

        /// <summary>
        /// The primary text to be inserted is treated as a snippet.
        /// 
        /// A snippet can define tab stops and placeholders with `$1`, `$2`
        /// and `${3:foo}`. `$0` defines the final tab stop, it defaults to
        /// the end of the snippet. Placeholders with equal identifiers are linked,
        /// that is typing in one will update others too.
        /// 
        /// See also: https://microsoft.github.io/language-server-protocol/specifications/specification-current/#snippet_syntax
        /// </summary>
        Snippet = 2,

    }
}
