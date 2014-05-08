if(CMAKE_CONFIGURATION_TYPES)
	unset(CMAKE_CXX_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_C_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_EXE_LINKER_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_MODULE_LINKER_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_SHARED_LINKER_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_STATIC_LINKER_FLAGS_MINSIZEREL CACHE)
	unset(CMAKE_CXX_FLAGS_RELWITHDEBINFO CACHE)
	unset(CMAKE_C_FLAGS_RELWITHDEBINFO CACHE)
	unset(CMAKE_EXE_LINKER_FLAGS_RELWITHDEBINFO CACHE)
	unset(CMAKE_MODULE_LINKER_FLAGS_RELWITHDEBINFO CACHE)
	unset(CMAKE_SHARED_LINKER_FLAGS_RELWITHDEBINFO CACHE)
	unset(CMAKE_STATIC_LINKER_FLAGS_RELWITHDEBINFO CACHE)
	
	set(CMAKE_CONFIGURATION_TYPES Debug;Release;Publish
		CACHE STRING "Available configurations")
		
	set(CMAKE_CXX_FLAGS_PUBLISH "/MD /O2 /Ob2 /D NDEBUG"
		CACHE STRING "Flags used by the compiler during publish builds.")
	set(CMAKE_C_FLAGS_PUBLISH "/MD /O2 /Ob2 /D NDEBUG"
		CACHE STRING "Flags used by the compiler during publish builds.")
	set(CMAKE_EXE_LINKER_FLAGS_PUBLISH "/INCREMENTAL:NO"
		CACHE STRING "Flags used by the linker during publish builds.")
	set(CMAKE_MODULE_LINKER_FLAGS_PUBLISH "/INCREMENTAL:NO"
		CACHE STRING "Flags used by the linker during publish builds.")
	set(CMAKE_SHARED_LINKER_FLAGS_PUBLISH "/INCREMENTAL:NO"
		CACHE STRING "Flags used by the linker during publish builds.")
	set(CMAKE_STATIC_LINKER_FLAGS_PUBLISH ""
		CACHE STRING "Flags used by the linker during publish builds.")
endif()

set(CMAKE_PROJECT_SOURCE_DIR ${PROJECT_SOURCE_DIR})
set(CMAKE_PROJECT_BINARY_DIR ${PROJECT_BINARY_DIR})

add_definitions(-D_UNICODE)
add_definitions(-D_WIN32)
