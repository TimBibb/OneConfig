cmake_minimum_required(VERSION 3.12)
project(OneConfig)

set(CMAKE_CXX_STANDARD 14)

add_executable(OneConfig main.cpp parser.cpp parser.h consolidator.cpp consolidator.h)