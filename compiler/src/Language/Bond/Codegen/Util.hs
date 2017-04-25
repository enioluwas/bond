-- Copyright (c) Microsoft. All rights reserved.
-- Licensed under the MIT license. See LICENSE file in the project root for full license information.

{-# LANGUAGE QuasiQuotes, OverloadedStrings #-}
{-# OPTIONS_GHC -fno-warn-orphans #-}

{-|
Copyright   : (c) Microsoft
License     : MIT
Maintainer  : adamsap@microsoft.com
Stability   : provisional
Portability : portable

Helper functions for creating common structures useful in code generation.
These functions often operate on 'Text' objects.
-}

module Language.Bond.Codegen.Util
    ( commonHeader
    , newlineSep
    , commaLineSep
    , newlineSepEnd
    , newlineBeginSep
    , doubleLineSep
    , doubleLineSepEnd
    , uniqueName
    ) where

import Data.Int (Int64)
import Data.Word
import Prelude
import Data.Text.Lazy (Text, justifyRight)
import Text.Shakespeare.Text
import Paths_bond (version)
import Data.Version (showVersion)
import Language.Bond.Util

instance ToText Word16 where
    toText = toText . show

instance ToText Double where
    toText = toText . show

instance ToText Integer where
    toText = toText . show

indent :: Int64 -> Text
indent n = justifyRight (4 * n) ' ' ""

commaLine :: Int64 -> Text
commaLine n = [lt|,
#{indent n}|]

newLine :: Int64 -> Text
newLine n = [lt|
#{indent n}|]

doubleLine :: Int64 -> Text
doubleLine n = [lt|

#{indent n}|]

newlineSep, commaLineSep, newlineSepEnd, newlineBeginSep, doubleLineSep, doubleLineSepEnd
    :: Int64 -> (a -> Text) -> [a] -> Text

-- | Separates elements of a list with new lines. Starts new lines at the
-- specified indentation level.
newlineSep = sepBy . newLine

-- | Separates elements of a list with comma followed by a new line. Starts
-- new lines at the specified indentation level.
commaLineSep = sepBy . commaLine

-- | Separates elements of a list with new lines, ending with a new line.
-- Starts new lines at the specified indentation level.
newlineSepEnd = sepEndBy . newLine

-- | Separates elements of a list with new lines, beginning with a new line.
-- Starts new lines at the specified indentation level.
newlineBeginSep = sepBeginBy . newLine

-- | Separates elements of a list with two new lines. Starts new lines at
-- the specified indentation level.
doubleLineSep = sepBy . doubleLine

-- | Separates elements of a list with two new lines, ending with two new
-- lines. Starts new lines at the specified indentation level.
doubleLineSepEnd = sepEndBy . doubleLine

-- | Returns common header for generated files using specified single-line
-- comment lead character(s) and a file name.
commonHeader ::  ToText a => a -> a -> Text
commonHeader c file = [lt|
#{c}------------------------------------------------------------------------------
#{c} This code was generated by a tool.
#{c}
#{c}   Tool : Bond Compiler #{showVersion version}
#{c}   File : #{file}
#{c}
#{c} Changes to this file may cause incorrect behavior and will be lost when
#{c} the code is regenerated.
#{c} <auto-generated />
#{c}------------------------------------------------------------------------------
|]

-- | Given an intended name and a list of already taken names, returns a
-- unique name. Assumes that it's legal to appen digits to the end of the
-- intended name.
uniqueName :: String -> [String] -> String
uniqueName baseName taken = go baseName (0::Integer)
  where go name counter
          | not (name `elem` taken) = name
          | otherwise = go newName (counter + 1)
                        where newName = baseName ++ (show counter)