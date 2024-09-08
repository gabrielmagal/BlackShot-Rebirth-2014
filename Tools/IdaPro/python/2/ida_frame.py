# This file was automatically generated by SWIG (http://www.swig.org).
# Version 4.0.0
#
# Do not make changes to this file unless you know what you are doing--modify
# the SWIG interface file instead.

"""
IDA Plugin SDK API wrapper: frame
"""

from sys import version_info as _swig_python_version_info
if _swig_python_version_info < (2, 7, 0):
    raise RuntimeError('Python 2.7 or later required')

# Import the low-level C/C++ module
if __package__ or '.' in __name__:
    from . import _ida_frame
else:
    import _ida_frame

try:
    import builtins as __builtin__
except ImportError:
    import __builtin__

def _swig_setattr_nondynamic(self, class_type, name, value, static=1):
    if name == "thisown":
        return self.this.own(value)
    if name == "this":
        if type(value).__name__ == 'SwigPyObject':
            self.__dict__[name] = value
            return
    method = class_type.__swig_setmethods__.get(name, None)
    if method:
        return method(self, value)
    if not static:
        object.__setattr__(self, name, value)
    else:
        raise AttributeError("You cannot add attributes to %s" % self)


def _swig_setattr(self, class_type, name, value):
    return _swig_setattr_nondynamic(self, class_type, name, value, 0)


def _swig_getattr(self, class_type, name):
    if name == "thisown":
        return self.this.own()
    method = class_type.__swig_getmethods__.get(name, None)
    if method:
        return method(self)
    raise AttributeError("'%s' object has no attribute '%s'" % (class_type.__name__, name))


def _swig_repr(self):
    try:
        strthis = "proxy of " + self.this.__repr__()
    except __builtin__.Exception:
        strthis = ""
    return "<%s.%s; %s >" % (self.__class__.__module__, self.__class__.__name__, strthis,)


def _swig_setattr_nondynamic_instance_variable(set):
    def set_instance_attr(self, name, value):
        if name == "thisown":
            self.this.own(value)
        elif name == "this":
            set(self, name, value)
        elif hasattr(self, name) and isinstance(getattr(type(self), name), property):
            set(self, name, value)
        else:
            raise AttributeError("You cannot add instance attributes to %s" % self)
    return set_instance_attr


def _swig_setattr_nondynamic_class_variable(set):
    def set_class_attr(cls, name, value):
        if hasattr(cls, name) and not isinstance(getattr(cls, name), property):
            set(cls, name, value)
        else:
            raise AttributeError("You cannot add class attributes to %s" % cls)
    return set_class_attr


def _swig_add_metaclass(metaclass):
    """
    Class decorator for adding a metaclass to a SWIG wrapped class - a slimmed down version of six.add_metaclass
    """
    def wrapper(cls):
        return metaclass(cls.__name__, cls.__bases__, cls.__dict__.copy())
    return wrapper


class _SwigNonDynamicMeta(type):
    """
    Meta class to enforce nondynamic attributes (no new attributes) for a class
    """
    __setattr__ = _swig_setattr_nondynamic_class_variable(type.__setattr__)


import weakref

SWIG_PYTHON_LEGACY_BOOL = _ida_frame.SWIG_PYTHON_LEGACY_BOOL

import ida_idaapi


import sys
_BC695 = sys.modules["__main__"].IDAPYTHON_COMPAT_695_API

if _BC695:






    def bc695redef(func):
        ida_idaapi._BC695.replace_fun(func)
        return func

import ida_range
class xreflist_t(object):
    r"""
    Proxy of C++ qvector< xreflist_entry_t > class.
    """

    thisown = property(lambda x: x.this.own(), lambda x, v: x.this.own(v), doc='The membership flag')
    __repr__ = _swig_repr

    def __init__(self, *args):
        r"""


        __init__(self) -> xreflist_t
            x: qvector< xreflist_entry_t > const &
        """
        _ida_frame.xreflist_t_swiginit(self, _ida_frame.new_xreflist_t(*args))
    __swig_destroy__ = _ida_frame.delete_xreflist_t

    def push_back(self, *args):
        r"""


        push_back(self, x)
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_push_back(self, *args)

    def pop_back(self, *args):
        r"""
        pop_back(self)
        """
        return _ida_frame.xreflist_t_pop_back(self, *args)

    def size(self, *args):
        r"""
        size(self) -> size_t
        """
        return _ida_frame.xreflist_t_size(self, *args)

    def empty(self, *args):
        r"""
        empty(self) -> bool
        """
        return _ida_frame.xreflist_t_empty(self, *args)

    def at(self, *args):
        r"""


        at(self, _idx) -> xreflist_entry_t
            _idx: size_t
        """
        return _ida_frame.xreflist_t_at(self, *args)

    def qclear(self, *args):
        r"""
        qclear(self)
        """
        return _ida_frame.xreflist_t_qclear(self, *args)

    def clear(self, *args):
        r"""
        clear(self)
        """
        return _ida_frame.xreflist_t_clear(self, *args)

    def resize(self, *args):
        r"""


        resize(self, _newsize, x)
            _newsize: size_t
            x: xreflist_entry_t const &
        

        resize(self, _newsize)
            _newsize: size_t
        """
        return _ida_frame.xreflist_t_resize(self, *args)

    def grow(self, *args):
        r"""


        grow(self, x=xreflist_entry_t())
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_grow(self, *args)

    def capacity(self, *args):
        r"""
        capacity(self) -> size_t
        """
        return _ida_frame.xreflist_t_capacity(self, *args)

    def reserve(self, *args):
        r"""


        reserve(self, cnt)
            cnt: size_t
        """
        return _ida_frame.xreflist_t_reserve(self, *args)

    def truncate(self, *args):
        r"""
        truncate(self)
        """
        return _ida_frame.xreflist_t_truncate(self, *args)

    def swap(self, *args):
        r"""


        swap(self, r)
            r: qvector< xreflist_entry_t > &
        """
        return _ida_frame.xreflist_t_swap(self, *args)

    def extract(self, *args):
        r"""
        extract(self) -> xreflist_entry_t
        """
        return _ida_frame.xreflist_t_extract(self, *args)

    def inject(self, *args):
        r"""


        inject(self, s, len)
            s: xreflist_entry_t *
            len: size_t
        """
        return _ida_frame.xreflist_t_inject(self, *args)

    def __eq__(self, *args):
        r"""


        __eq__(self, r) -> bool
            r: qvector< xreflist_entry_t > const &
        """
        return _ida_frame.xreflist_t___eq__(self, *args)

    def __ne__(self, *args):
        r"""


        __ne__(self, r) -> bool
            r: qvector< xreflist_entry_t > const &
        """
        return _ida_frame.xreflist_t___ne__(self, *args)

    def begin(self, *args):
        r"""
        begin(self) -> xreflist_entry_t
        begin(self) -> xreflist_entry_t
        """
        return _ida_frame.xreflist_t_begin(self, *args)

    def end(self, *args):
        r"""
        end(self) -> xreflist_entry_t
        end(self) -> xreflist_entry_t
        """
        return _ida_frame.xreflist_t_end(self, *args)

    def insert(self, *args):
        r"""


        insert(self, it, x) -> xreflist_entry_t
            it: qvector< xreflist_entry_t >::iterator
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_insert(self, *args)

    def erase(self, *args):
        r"""


        erase(self, it) -> xreflist_entry_t
            it: qvector< xreflist_entry_t >::iterator
        

        erase(self, first, last) -> xreflist_entry_t
            first: qvector< xreflist_entry_t >::iterator
            last: qvector< xreflist_entry_t >::iterator
        """
        return _ida_frame.xreflist_t_erase(self, *args)

    def find(self, *args):
        r"""


        find(self, x) -> xreflist_entry_t
            x: xreflist_entry_t const &
        

        find(self, x) -> xreflist_entry_t
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_find(self, *args)

    def has(self, *args):
        r"""


        has(self, x) -> bool
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_has(self, *args)

    def add_unique(self, *args):
        r"""


        add_unique(self, x) -> bool
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t_add_unique(self, *args)

    def _del(self, *args):
        r"""


        _del(self, x) -> bool
            x: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t__del(self, *args)

    def __len__(self, *args):
        r"""
        __len__(self) -> size_t
        """
        return _ida_frame.xreflist_t___len__(self, *args)

    def __getitem__(self, *args):
        r"""


        __getitem__(self, i) -> xreflist_entry_t
            i: size_t
        """
        return _ida_frame.xreflist_t___getitem__(self, *args)

    def __setitem__(self, *args):
        r"""


        __setitem__(self, i, v)
            i: size_t
            v: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_t___setitem__(self, *args)

    front = ida_idaapi._qvector_front
    back = ida_idaapi._qvector_back
    __iter__ = ida_idaapi._bounded_getitem_iterator


# Register xreflist_t in _ida_frame:
_ida_frame.xreflist_t_swigregister(xreflist_t)


def get_stkvar(*args):
    r"""


    get_stkvar(insn, op, v) -> PyObject *
    Get pointer to stack variable
    @param op: reference to instruction operand
    @param v: immediate value in the operand (usually op.addr)
    @return:
        - None on failure
        - tuple(member_t, actval)
          where actval: actual value used to fetch stack variable
    """
    return _ida_frame.get_stkvar(*args)

def is_funcarg_off(*args):
    r"""


    is_funcarg_off(pfn, frameoff) -> bool
        pfn: func_t const *
        frameoff: uval_t
    """
    return _ida_frame.is_funcarg_off(*args)

def lvar_off(*args):
    r"""


    lvar_off(pfn, frameoff) -> sval_t
        pfn: func_t const *
        frameoff: uval_t
    """
    return _ida_frame.lvar_off(*args)
class stkpnt_t(object):
    r"""
    Proxy of C++ stkpnt_t class.
    """

    thisown = property(lambda x: x.this.own(), lambda x, v: x.this.own(v), doc='The membership flag')
    __repr__ = _swig_repr
    ea = property(_ida_frame.stkpnt_t_ea_get, _ida_frame.stkpnt_t_ea_set)
    spd = property(_ida_frame.stkpnt_t_spd_get, _ida_frame.stkpnt_t_spd_set)

    def __eq__(self, *args):
        r"""


        __eq__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___eq__(self, *args)

    def __ne__(self, *args):
        r"""


        __ne__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___ne__(self, *args)

    def __lt__(self, *args):
        r"""


        __lt__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___lt__(self, *args)

    def __gt__(self, *args):
        r"""


        __gt__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___gt__(self, *args)

    def __le__(self, *args):
        r"""


        __le__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___le__(self, *args)

    def __ge__(self, *args):
        r"""


        __ge__(self, r) -> bool
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t___ge__(self, *args)

    def compare(self, *args):
        r"""


        compare(self, r) -> int
            r: stkpnt_t const &
        """
        return _ida_frame.stkpnt_t_compare(self, *args)

    def __init__(self, *args):
        r"""
        __init__(self) -> stkpnt_t
        """
        _ida_frame.stkpnt_t_swiginit(self, _ida_frame.new_stkpnt_t(*args))
    __swig_destroy__ = _ida_frame.delete_stkpnt_t

# Register stkpnt_t in _ida_frame:
_ida_frame.stkpnt_t_swigregister(stkpnt_t)

class stkpnts_t(object):
    r"""
    Proxy of C++ stkpnts_t class.
    """

    thisown = property(lambda x: x.this.own(), lambda x, v: x.this.own(v), doc='The membership flag')
    __repr__ = _swig_repr

    def __eq__(self, *args):
        r"""


        __eq__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___eq__(self, *args)

    def __ne__(self, *args):
        r"""


        __ne__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___ne__(self, *args)

    def __lt__(self, *args):
        r"""


        __lt__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___lt__(self, *args)

    def __gt__(self, *args):
        r"""


        __gt__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___gt__(self, *args)

    def __le__(self, *args):
        r"""


        __le__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___le__(self, *args)

    def __ge__(self, *args):
        r"""


        __ge__(self, r) -> bool
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t___ge__(self, *args)

    def compare(self, *args):
        r"""


        compare(self, r) -> int
            r: stkpnts_t const &
        """
        return _ida_frame.stkpnts_t_compare(self, *args)

    def __init__(self, *args):
        r"""
        __init__(self) -> stkpnts_t
        """
        _ida_frame.stkpnts_t_swiginit(self, _ida_frame.new_stkpnts_t(*args))
    __swig_destroy__ = _ida_frame.delete_stkpnts_t

# Register stkpnts_t in _ida_frame:
_ida_frame.stkpnts_t_swigregister(stkpnts_t)


def add_frame(*args):
    r"""


    Add function frame.
    
    add_frame(pfn, frsize, frregs, argsize) -> bool
        @param pfn: pointer to function structure (C++: func_t  *)
        @param frsize: size of function local variables (C++: sval_t)
        @param frregs: size of saved registers (C++: ushort)
        @param argsize: size of function arguments range which will be purged
                        upon return. this parameter is used for __stdcall and
                        __pascal calling conventions. for other calling
                        conventions please pass 0. (C++: asize_t)
        @retval: 1 - ok
        @retval: 0 - failed (no function, frame already exists)
    """
    return _ida_frame.add_frame(*args)

def del_frame(*args):
    r"""


    Delete a function frame.
    
    del_frame(pfn) -> bool
        @param pfn: pointer to function structure (C++: func_t  *)
        @return: success
    """
    return _ida_frame.del_frame(*args)

def set_frame_size(*args):
    r"""


    Set size of function frame. Note: The returned size may not include
    all stack arguments. It does so only for __stdcall and __fastcall
    calling conventions. To get the entire frame size for all cases use
    get_struc_size(get_frame(pfn)).
    
    set_frame_size(pfn, frsize, frregs, argsize) -> bool
        @param pfn: pointer to function structure (C++: func_t  *)
        @param frsize: size of function local variables (C++: asize_t)
        @param frregs: size of saved registers (C++: ushort)
        @param argsize: size of function arguments that will be purged from
                        the stack upon return (C++: asize_t)
        @return: success
    """
    return _ida_frame.set_frame_size(*args)

def get_frame_size(*args):
    r"""


    Get full size of a function frame. This function takes into account
    size of local variables + size of saved registers + size of return
    address + number of purged bytes. The purged bytes correspond to the
    arguments of the functions with __stdcall and __fastcall calling
    conventions.
    
    get_frame_size(pfn) -> asize_t
        @param pfn: pointer to function structure, may be NULL (C++: const
                    func_t  *)
        @return: size of frame in bytes or zero
    """
    return _ida_frame.get_frame_size(*args)

def get_frame_retsize(*args):
    r"""


    Get size of function return address.
    
    get_frame_retsize(pfn) -> int
        @param pfn: pointer to function structure, can't be NULL (C++: const
                    func_t  *)
    """
    return _ida_frame.get_frame_retsize(*args)
FPC_ARGS = _ida_frame.FPC_ARGS

FPC_RETADDR = _ida_frame.FPC_RETADDR

FPC_SAVREGS = _ida_frame.FPC_SAVREGS

FPC_LVARS = _ida_frame.FPC_LVARS


def get_frame_part(*args):
    r"""


    Get offsets of the frame part in the frame.
    
    get_frame_part(range, pfn, part)
        @param range: pointer to the output buffer with the frame part
                      start/end(exclusive) offsets, can't be NULL (C++:
                      range_t  *)
        @param pfn: pointer to function structure, can't be NULL (C++: const
                    func_t  *)
        @param part: frame part (C++: frame_part_t)
    """
    return _ida_frame.get_frame_part(*args)

def frame_off_args(*args):
    r"""


    Get starting address of arguments section.
    
    frame_off_args(pfn) -> ea_t
        @param pfn (C++: const  func_t  *)
    """
    return _ida_frame.frame_off_args(*args)

def frame_off_retaddr(*args):
    r"""


    Get starting address of return address section.
    
    frame_off_retaddr(pfn) -> ea_t
        @param pfn (C++: const  func_t  *)
    """
    return _ida_frame.frame_off_retaddr(*args)

def frame_off_savregs(*args):
    r"""


    Get starting address of saved registers section.
    
    frame_off_savregs(pfn) -> ea_t
        @param pfn (C++: const  func_t  *)
    """
    return _ida_frame.frame_off_savregs(*args)

def frame_off_lvars(*args):
    r"""


    Get start address of local variables section.
    
    frame_off_lvars(pfn) -> ea_t
        @param pfn (C++: const  func_t  *)
    """
    return _ida_frame.frame_off_lvars(*args)

def get_frame(*args):
    r"""


    Get pointer to function frame.
    
    get_frame(pfn) -> struc_t
        @param pfn: pointer to function structure (C++: const  func_t  *)
    

    get_frame(ea) -> struc_t *
        ea: ea_t
    """
    return _ida_frame.get_frame(*args)

def soff_to_fpoff(*args):
    r"""


    Convert struct offsets into fp-relative offsets. This function
    converts the offsets inside the 'struc_t' object into the frame
    pointer offsets (for example, EBP-relative).
    
    soff_to_fpoff(pfn, soff) -> sval_t
        @param pfn (C++: func_t  *)
        @param soff (C++: uval_t)
    """
    return _ida_frame.soff_to_fpoff(*args)

def update_fpd(*args):
    r"""


    Update frame pointer delta.
    
    update_fpd(pfn, fpd) -> bool
        @param pfn: pointer to function structure (C++: func_t  *)
        @param fpd: new fpd value. cannot be bigger than the local variable
                    range size. (C++: asize_t)
        @return: success
    """
    return _ida_frame.update_fpd(*args)

def set_purged(*args):
    r"""


    Set the number of purged bytes for a function or data item (funcptr).
    This function will update the database and plan to reanalyze items
    referencing the specified address. It works only for processors with
    'PR_PURGING' bit in 16 and 32 bit modes.
    
    set_purged(ea, nbytes, override_old_value) -> bool
        @param ea: address of the function of item (C++: ea_t)
        @param nbytes: number of purged bytes (C++: int)
        @param override_old_value: may overwrite old information about purged
                                   bytes (C++: bool)
        @return: success
    """
    return _ida_frame.set_purged(*args)

def get_func_by_frame(*args):
    r"""


    Get function by its frame id.this function works only with databases
    created by IDA > 5.6
    
    get_func_by_frame(frame_id) -> ea_t
        @param frame_id: id of the function frame (C++: tid_t)
        @return: start address of the function or  BADADDR
    """
    return _ida_frame.get_func_by_frame(*args)
STKVAR_VALID_SIZE = _ida_frame.STKVAR_VALID_SIZE
"""
x.dtyp contains correct variable type (for insns like 'lea' this bit
must be off) in general, dr_O references do not allow to determine the
variable size
"""


def define_stkvar(*args):
    r"""


    Define/redefine a stack variable.
    
    define_stkvar(pfn, name, off, flags, ti, nbytes) -> bool
        @param pfn: pointer to function (C++: func_t  *)
        @param name: variable name, NULL means autogenerate a name (C++: const
                     char *)
        @param off: offset of the stack variable in the frame. negative values
                    denote local variables, positive - function arguments.
                    (C++: sval_t)
        @param flags: variable type flags ( byte_flag()  for a byte variable,
                      for example) (C++: flags_t)
        @param ti: additional type information (like offsets, structs, etc)
                   (C++: const  opinfo_t  *)
        @param nbytes: number of bytes occupied by the variable (C++: asize_t)
        @return: success
    """
    return _ida_frame.define_stkvar(*args)

def build_stkvar_name(*args):
    r"""


    Build automatic stack variable name.
    
    build_stkvar_name(pfn, v) -> str
        @param pfn: pointer to function (can't be NULL!) (C++: const  func_t
                    *)
        @param v: value of variable offset (C++: sval_t)
        @return: length of stack variable name or -1
    """
    return _ida_frame.build_stkvar_name(*args)

def calc_stkvar_struc_offset(*args):
    r"""


    Calculate offset of stack variable in the frame structure.
    
    calc_stkvar_struc_offset(pfn, insn, n) -> ea_t
        @param pfn: pointer to function (can't be NULL!) (C++: func_t  *)
        @param insn: the instruction  - an ida_ua.insn_t, or an address (C++:
                     const insn_t &)
        @param n: number of operand: (0.. UA_MAXOP -1) -1 if error, return
                  BADADDR (C++: int)
        @return: BADADDR  if some error (issue a warning if stack frame is
                 bad)
    """
    return _ida_frame.calc_stkvar_struc_offset(*args)
class regvar_t(ida_range.range_t):
    r"""
    Proxy of C++ regvar_t class.
    """

    thisown = property(lambda x: x.this.own(), lambda x, v: x.this.own(v), doc='The membership flag')
    __repr__ = _swig_repr
    canon = property(_ida_frame.regvar_t_canon_get, _ida_frame.regvar_t_canon_set)
    user = property(_ida_frame.regvar_t_user_get, _ida_frame.regvar_t_user_set)
    cmt = property(_ida_frame.regvar_t_cmt_get, _ida_frame.regvar_t_cmt_set)

    def __init__(self, *args):
        r"""
        __init__(self) -> regvar_t
        """
        _ida_frame.regvar_t_swiginit(self, _ida_frame.new_regvar_t(*args))
    __swig_destroy__ = _ida_frame.delete_regvar_t

# Register regvar_t in _ida_frame:
_ida_frame.regvar_t_swigregister(regvar_t)


def add_regvar(*args):
    r"""


    Define a register variable.
    
    add_regvar(pfn, ea1, ea2, canon, user, cmt) -> int
        @param pfn: function in which the definition will be created (C++:
                    func_t  *)
        @param ea1: range of addresses within the function where the
                    definition will be used (C++: ea_t)
        @param ea2: range of addresses within the function where the
                    definition will be used (C++: ea_t)
        @param canon: name of a general register (C++: const char *)
        @param user: user-defined name for the register (C++: const char *)
        @param cmt: comment for the definition (C++: const char *)
        @return: Register variable error codes
    """
    return _ida_frame.add_regvar(*args)
REGVAR_ERROR_OK = _ida_frame.REGVAR_ERROR_OK
"""
all ok
"""

REGVAR_ERROR_ARG = _ida_frame.REGVAR_ERROR_ARG
"""
function arguments are bad
"""

REGVAR_ERROR_RANGE = _ida_frame.REGVAR_ERROR_RANGE
"""
the definition range is bad
"""

REGVAR_ERROR_NAME = _ida_frame.REGVAR_ERROR_NAME
"""
the provided name(s) can't be accepted
"""


def find_regvar(*args):
    r"""


    Find a register variable definition (powerful version). One of 'canon'
    and 'user' should be NULL. If both 'canon' and 'user' are NULL it
    returns the first regvar definition in the range.
    
    find_regvar(pfn, ea1, ea2, canon, user) -> regvar_t
        @param pfn: function in question (C++: func_t  *)
        @param ea1: range of addresses to search. ea1==BADADDR means the
                    entire function (C++: ea_t)
        @param ea2: range of addresses to search. ea1==BADADDR means the
                    entire function (C++: ea_t)
        @param canon: name of a general register (C++: const char *)
        @param user: user-defined name for the register (C++: const char *)
        @return: NULL-not found, otherwise ptr to  regvar_t
    

    find_regvar(pfn, ea, canon) -> regvar_t
        @param pfn: function in question (C++: func_t  *)
        ea: ea_t
        @param canon: name of a general register (C++: const char *)
        @return: NULL-not found, otherwise ptr to  regvar_t
    """
    return _ida_frame.find_regvar(*args)

def has_regvar(*args):
    r"""


    Is there a register variable definition?
    
    has_regvar(pfn, ea) -> bool
        @param pfn: function in question (C++: func_t  *)
        @param ea: current address (C++: ea_t)
    """
    return _ida_frame.has_regvar(*args)

def rename_regvar(*args):
    r"""


    Rename a register variable.
    
    rename_regvar(pfn, v, user) -> int
        @param pfn: function in question (C++: func_t  *)
        @param v: variable to rename (C++: regvar_t  *)
        @param user: new user-defined name for the register (C++: const char
                     *)
        @return: Register variable error codes
    """
    return _ida_frame.rename_regvar(*args)

def set_regvar_cmt(*args):
    r"""


    Set comment for a register variable.
    
    set_regvar_cmt(pfn, v, cmt) -> int
        @param pfn: function in question (C++: func_t  *)
        @param v: variable to rename (C++: regvar_t  *)
        @param cmt: new comment (C++: const char *)
        @return: Register variable error codes
    """
    return _ida_frame.set_regvar_cmt(*args)

def del_regvar(*args):
    r"""


    Delete a register variable definition.
    
    del_regvar(pfn, ea1, ea2, canon) -> int
        @param pfn: function in question (C++: func_t  *)
        @param ea1: range of addresses within the function where the
                    definition holds (C++: ea_t)
        @param ea2: range of addresses within the function where the
                    definition holds (C++: ea_t)
        @param canon: name of a general register (C++: const char *)
        @return: Register variable error codes
    """
    return _ida_frame.del_regvar(*args)

def add_auto_stkpnt(*args):
    r"""


    Add automatic SP register change point.
    
    add_auto_stkpnt(pfn, ea, delta) -> bool
        @param pfn: pointer to function. may be NULL. (C++: func_t  *)
        @param ea: linear address where SP changes. usually this is the end of
                   the instruction which modifies the stack pointer
                   (\cmd{ea}+\cmd{size}) (C++: ea_t)
        @param delta: difference between old and new values of SP (C++:
                      sval_t)
        @return: success
    """
    return _ida_frame.add_auto_stkpnt(*args)

def add_user_stkpnt(*args):
    r"""


    Add user-defined SP register change point.
    
    add_user_stkpnt(ea, delta) -> bool
        @param ea: linear address where SP changes (C++: ea_t)
        @param delta: difference between old and new values of SP (C++:
                      sval_t)
        @return: success
    """
    return _ida_frame.add_user_stkpnt(*args)

def del_stkpnt(*args):
    r"""


    Delete SP register change point.
    
    del_stkpnt(pfn, ea) -> bool
        @param pfn: pointer to function. may be NULL. (C++: func_t  *)
        @param ea: linear address (C++: ea_t)
        @return: success
    """
    return _ida_frame.del_stkpnt(*args)

def get_spd(*args):
    r"""


    Get difference between the initial and current values of ESP.
    
    get_spd(pfn, ea) -> sval_t
        @param pfn: pointer to function. may be NULL. (C++: func_t  *)
        @param ea: linear address of an instruction (C++: ea_t)
        @return: 0 or the difference, usually a negative number. returns the
                 sp-diff before executing the instruction.
    """
    return _ida_frame.get_spd(*args)

def get_effective_spd(*args):
    r"""


    Get effective difference between the initial and current values of
    ESP. This function returns the sp-diff used by the instruction. The
    difference between 'get_spd()' and 'get_effective_spd()' is present
    only for instructions like "pop [esp+N]": they modify sp and use the
    modified value.
    
    get_effective_spd(pfn, ea) -> sval_t
        @param pfn: pointer to function. may be NULL. (C++: func_t  *)
        @param ea: linear address (C++: ea_t)
        @return: 0 or the difference, usually a negative number
    """
    return _ida_frame.get_effective_spd(*args)

def get_sp_delta(*args):
    r"""


    Get modification of SP made at the specified location
    
    get_sp_delta(pfn, ea) -> sval_t
        @param pfn: pointer to function. may be NULL. (C++: func_t  *)
        @param ea: linear address (C++: ea_t)
        @return: 0 if the specified location doesn't contain a SP change
                 point. otherwise return delta of SP modification.
    """
    return _ida_frame.get_sp_delta(*args)

def recalc_spd(*args):
    r"""


    Recalculate SP delta for an instruction that stops execution. The next
    instruction is not reached from the current instruction. We need to
    recalculate SP for the next instruction.This function will create a
    new automatic SP register change point if necessary. It should be
    called from the emulator (emu.cpp) when auto_state == 'AU_USED' if the
    current instruction doesn't pass the execution flow to the next
    instruction.
    
    recalc_spd(cur_ea) -> bool
        @param cur_ea: linear address of the current instruction (C++: ea_t)
        @retval: 1 - new stkpnt is added
        @retval: 0 - nothing is changed
    """
    return _ida_frame.recalc_spd(*args)
class xreflist_entry_t(object):
    r"""
    Proxy of C++ xreflist_entry_t class.
    """

    thisown = property(lambda x: x.this.own(), lambda x, v: x.this.own(v), doc='The membership flag')
    __repr__ = _swig_repr
    ea = property(_ida_frame.xreflist_entry_t_ea_get, _ida_frame.xreflist_entry_t_ea_set)
    opnum = property(_ida_frame.xreflist_entry_t_opnum_get, _ida_frame.xreflist_entry_t_opnum_set)
    type = property(_ida_frame.xreflist_entry_t_type_get, _ida_frame.xreflist_entry_t_type_set)

    def __eq__(self, *args):
        r"""


        __eq__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___eq__(self, *args)

    def __ne__(self, *args):
        r"""


        __ne__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___ne__(self, *args)

    def __lt__(self, *args):
        r"""


        __lt__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___lt__(self, *args)

    def __gt__(self, *args):
        r"""


        __gt__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___gt__(self, *args)

    def __le__(self, *args):
        r"""


        __le__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___le__(self, *args)

    def __ge__(self, *args):
        r"""


        __ge__(self, r) -> bool
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t___ge__(self, *args)

    def compare(self, *args):
        r"""


        compare(self, r) -> int
            r: xreflist_entry_t const &
        """
        return _ida_frame.xreflist_entry_t_compare(self, *args)

    def __init__(self, *args):
        r"""
        __init__(self) -> xreflist_entry_t
        """
        _ida_frame.xreflist_entry_t_swiginit(self, _ida_frame.new_xreflist_entry_t(*args))
    __swig_destroy__ = _ida_frame.delete_xreflist_entry_t

# Register xreflist_entry_t in _ida_frame:
_ida_frame.xreflist_entry_t_swigregister(xreflist_entry_t)


def build_stkvar_xrefs(*args):
    r"""


    Fill 'out' with a list of all the xrefs made from function 'pfn', to
    the argument or variable 'mptr' in 'pfn's stack frame.
    
    build_stkvar_xrefs(out, pfn, mptr)
        @param out: the list of xrefs to fill. (C++: xreflist_t  *)
        @param pfn: the function to scan. (C++: func_t  *)
        @param mptr: the argument/variable in pfn's stack frame. (C++: const
                     member_t  *)
    """
    return _ida_frame.build_stkvar_xrefs(*args)

def get_min_spd_ea(*args):
    r"""


    get_min_spd_ea(pfn) -> ea_t
        @param pfn (C++: func_t  *)
    """
    return _ida_frame.get_min_spd_ea(*args)

def delete_unreferenced_stkvars(*args):
    r"""


    delete_unreferenced_stkvars(pfn) -> int
        @param pfn (C++: func_t  *)
    """
    return _ida_frame.delete_unreferenced_stkvars(*args)

def delete_wrong_stkvar_ops(*args):
    r"""


    delete_wrong_stkvar_ops(pfn) -> int
        @param pfn (C++: func_t  *)
    """
    return _ida_frame.delete_wrong_stkvar_ops(*args)

if _BC695:
    add_auto_stkpnt2=add_auto_stkpnt
# in fact, we cannot simulate add_stkvar[23] here, because we simply
# don't have the insn_t object -- and no way of retrieving it, either,
# since cmd is gone
    @bc695redef
    def get_stkvar(*args):
        if len(args) == 2:
            import ida_ua
            insn, op, v = ida_ua.cmd, args[0], args[1]
        else:
            insn, op, v = args
        return _ida_frame.get_stkvar(insn, op, v)
    @bc695redef
    def get_frame_part(*args):
        import ida_funcs
        if isinstance(args[0], ida_funcs.func_t): # 6.95: pfn, part, range
            rnge, pfn, part = args[2], args[0], args[1]
        else:                                     # 7.00: range, pfn, part
            rnge, pfn, part = args
        return _ida_frame.get_frame_part(rnge, pfn, part)



